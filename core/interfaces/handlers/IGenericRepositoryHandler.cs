namespace TravelerFellas;

public interface IGenericRepositoryHandler<TData>
    where TData : class
{
    public Task<Response<TData?>> CreateTDataAsync(TData TDataDTO, Request request);
    public Task<Response<TData?>> DeletePorIdAsync(int id, Request request);
    public Task<Response<TData?>> GetPorIdAsync(int id, Request request);
    public Task<Response<TData?>> UpdatePorIdAsync(int id, TData TDataDTO, Request request);
}
