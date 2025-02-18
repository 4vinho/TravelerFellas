namespace TravelerFellas;

public interface ICambioExternalServices
{
    public Task<Response<CambioDTO>> GetCambioAsync(
        string deMoeda,
        string paraMoeda,
        Request request
    );
}
