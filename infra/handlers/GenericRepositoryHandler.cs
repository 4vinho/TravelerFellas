using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace TravelerFellas;

public class GenericRepositoryHandler<TData, TDataDTO>(AppDbContext context, IMapper _mapper)
    : IGenericRepositoryHandler<TDataDTO>
    where TData : BaseEntity
    where TDataDTO : class
{
    public async Task<Response<TDataDTO?>> CreateTDataAsync(TDataDTO TDataDTO, Request request)
    {
        try
        {
            if (TDataDTO == null)
                return new Response<TDataDTO?>(400, "Data is null", null);

            var tData = _mapper.Map<TData>(TDataDTO);

            await context.Set<TData>().AddAsync(tData);
            await context.SaveChangesAsync();

            var tDataDTO = _mapper.Map<TDataDTO>(tData);

            return new Response<TDataDTO?>(201, "Create is success", tDataDTO);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new Response<TDataDTO?>(500, "Internal Error", null);
        }
    }

    public async Task<Response<TDataDTO?>> DeletePorIdAsync(int id, Request request)
    {
        try
        {
            var tData = await context.Set<TData>().FirstOrDefaultAsync(x => x.Id == id);

            if (tData == null)
                return new Response<TDataDTO?>(404, "Not found", null);

            context.Set<TData>().Remove(tData);
            await context.SaveChangesAsync();

            return new Response<TDataDTO?>(204, "Delete is success", null);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new Response<TDataDTO?>(500, "Internal Error", null);
        }
    }

    public async Task<Response<TDataDTO?>> GetPorIdAsync(int id, Request request)
    {
        try
        {
            var tData = await context.Set<TData>().FirstOrDefaultAsync(x => x.Id == id);
            if (tData == null)
                return new Response<TDataDTO?>(404, "Not found", null);

            var tDataDTO = _mapper.Map<TDataDTO>(tData);

            return new Response<TDataDTO?>(200, "Get is success", tDataDTO);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new Response<TDataDTO?>(500, "Internal Error", null);
        }
    }

    public async Task<Response<TDataDTO?>> UpdatePorIdAsync(
        int id,
        TDataDTO TDataDTO,
        Request request
    )
    {
        try
        {
            var tData = await context.Set<TData>().FirstOrDefaultAsync(x => x.Id == id);
            if (tData == null)
                return new Response<TDataDTO?>(404, "Not found", null);

            _mapper.Map(TDataDTO, tData);

            context.Set<TData>().Update(tData);
            await context.SaveChangesAsync();

            var tDataDTO = _mapper.Map<TDataDTO>(tData);
            return new Response<TDataDTO?>(200, "Update is success", tDataDTO);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new Response<TDataDTO?>(500, "Internal Error", null);
        }
    }
}
