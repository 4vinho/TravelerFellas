namespace TravelerFellas;

public interface IEventoLocalExternalServices
{
    public Task<Response<EventoLocalDTO>> GetEventoLocalPorCidadeAsync(
        string nomeCidade,
        Request request
    );
}
