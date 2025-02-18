namespace TravelerFellas;

public interface IPontoTuristicoExternalServices
{
    public Task<Response<PontoTuristicoDTO>> CreatePontoTuristicoPorCidade(
        string nomeCidade,
        Request request
    );
}
