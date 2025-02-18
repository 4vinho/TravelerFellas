namespace TravelerFellas;

public interface IDestinoHandler : IGenericRepositoryHandler<DestinoDTO>
{
    public Task<PagedResponse<DestinoDTO>> GetDestinoTodosAsync(PagedRequest pagedResponse);
}
