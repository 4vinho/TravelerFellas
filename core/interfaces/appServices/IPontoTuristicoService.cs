using Microsoft.AspNetCore.Mvc;

namespace TravelerFellas;

public interface IPontoTuristicoService
{
    //Get - /api/ponto-turistico/city?
    public Task<IActionResult> GetPontoTuristicoByCityAsync();

    //Get - /api/ponto-turistico/destinoId
    public Task<IActionResult> GetPontoTuristicoByDestinoIdAsync();

    //Post - /api/ponto-turistico/update
    public Task<IActionResult> UpdatePontoTuristicoAsync();
}
