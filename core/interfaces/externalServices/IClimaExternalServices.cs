namespace TravelerFellas;

public interface IClimaExternalServices
{
    public Task<Response<ClimaDTO>> CreateClimaPorCidadeAsync(string nomeCidade, Request request);
}
