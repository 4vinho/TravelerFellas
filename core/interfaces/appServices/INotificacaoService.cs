using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface INotificacaoService
{
    //Get - /api/notificacao/userId
    public Task<IActionResult> GetNotificacaoByUserIdAsync();

    //Post - /api/notificacao/send
    public Task<IActionResult> CreateNotificacaoAsync();

    //Put - /api/notificacao/id/lida
    public Task<IActionResult> UpdateNotificacaoAsync();
}
