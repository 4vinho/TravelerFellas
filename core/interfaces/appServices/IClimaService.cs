using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface IClimaService
{
    //Get - /api/clima/city?
    public Task<IActionResult> GetClimaByCityAsync();

    //Get - /api/clima/DestinoId
    public Task<IActionResult> GetClimaByDestinoIdAsync();

    //Post - /api/clima/update
    public Task<IActionResult> UpdateClimaAsync();
}
