using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface IUsuarioService
{
    //Post - /api/usuario/register
    public Task<IActionResult> RegisterClientAsync();

    //Post - /api/usuario/login
    public Task<IActionResult> LoginClientAsync();

    //Get - /api/usuario/id
    public Task<IActionResult> GetUserAsync();

    //Put - /api/usuario/id
    public Task<IActionResult> UpdateUserAsync();

    //Delete - /api/usuario/id
    public Task<IActionResult> DeleteUserAsync();
}
