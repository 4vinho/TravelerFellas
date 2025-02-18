namespace TravelerFellas;

public interface IEventoLocalExternalServices
{
    public Task<Response<EventoLocalDTO>> CreateEventoLocalPorCidadeAsync(
        string nomeCidade,
        Request request
    );
}
