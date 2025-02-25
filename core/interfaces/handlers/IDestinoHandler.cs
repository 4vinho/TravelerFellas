namespace TravelerFellas;

public interface IDestinoHandler
{
    public Task<PagedResponse<IEnumerable<DestinoDTO>?>> GetDestinoTodosAsync(
        PagedRequest pagedRequest
    );
}
