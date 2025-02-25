using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface IEventoLocalService
{
    //Get - /api/local-events/city?
    public Task<IActionResult> GetEventoLocalByCityAsync();

    //Get - /api/local-events/destinoId
    public Task<IActionResult> GetEventoLocalByDestinoIdAsync();

    //Post - /api/local-events/update
    public Task<IActionResult> UptadeEventoLocalAsync();
}
