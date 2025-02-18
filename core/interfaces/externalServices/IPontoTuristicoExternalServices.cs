namespace TravelerFellas;

public interface IPontoTuristicoExternalServices
{
    public Task<Response<PontoTuristicoDTO>> GetPontoTuristicoPorCidade(
        string nomeCidade,
        Request request
    );
}
