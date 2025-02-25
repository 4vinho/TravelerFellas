using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface IDestinoService
{
    //Get - /api/destinos
    public Task<IActionResult> GetDestinosAsync();

    //Get - /api/destinos/id
    public Task<IActionResult> GetDestinoByIdAsync();

    //Post - /api/destinos/
    public Task<IActionResult> CreateDestinoAsync();

    //Put - /api/destinos/id
    public Task<IActionResult> UpdateDestinoAsync();

    //Delete - /api/destinos/id
    public Task<IActionResult> DeleteDestinoAsync();
}
