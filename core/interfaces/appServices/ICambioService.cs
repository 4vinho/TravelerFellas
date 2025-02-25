using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace TravelerFellas;

public interface ICambioService 
{
    //Get - /api/from=VAR&to=VAR
    public Task<IActionResult> GetCambioAsync();
}
