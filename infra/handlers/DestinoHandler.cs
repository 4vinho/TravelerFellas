using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace TravelerFellas;

public class DestinoHandler(AppDbContext context, IMapper _mapper) : IDestinoHandler
{
    public async Task<PagedResponse<IEnumerable<DestinoDTO>?>> GetDestinoTodosAsync(
        PagedRequest pagedRequest
    )
    {
        try
        {
            var destino = await context
                .Destino.OrderBy(x => x.Pais)
                .Skip((pagedRequest.PageCount - 1) * pagedRequest.PageSize)
                .Take(pagedRequest.PageSize)
                .ToListAsync();

            if (!destino.Any())
                return new PagedResponse<IEnumerable<DestinoDTO>?>(404, "Client not found", null);

            var destinoDTOCollection = _mapper.Map<IEnumerable<DestinoDTO>>(destino);

            return new PagedResponse<IEnumerable<DestinoDTO>?>(
                200,
                "Get is success",
                destinoDTOCollection,
                pagedRequest.PageSize,
                pagedRequest.PageCount
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new PagedResponse<IEnumerable<DestinoDTO>?>(500, "Internal Error", null);
        }
    }
}
