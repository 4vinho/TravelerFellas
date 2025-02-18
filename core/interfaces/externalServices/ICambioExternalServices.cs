namespace TravelerFellas;

public interface ICambioExternalServices
{
    public Task<Response<CambioDTO>> CreateCambioAsync(
        string deMoeda,
        string paraMoeda,
        Request request
    );
}
