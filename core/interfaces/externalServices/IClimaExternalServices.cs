namespace TravelerFellas;

public interface IClimaExternalServices
{
    public Task<Response<ClimaDTO>> GetClimaPorCidadeAsync(string nomeCidade, Request request);
}
