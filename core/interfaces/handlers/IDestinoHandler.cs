namespace TravelerFellas;

public interface IDestinoHandler : IGenericRepositoryHandler<DestinoDTO>
{
    public Task<PagedResponse<DestinoDTO>> GetDestinoAll(PagedRequest pagedResponse);
}
