
using System.Text.Json;

namespace TravelerFellas;

public class CambioExternalService : ICambioExternalServices
{

    private static readonly HttpClient httpClient = new()
    {
        BaseAddress = new Uri("https://economia.awesomeapi.com.br"),
    };


    public async Task<Response<CambioDTO>> CreateCambioAsync(string deMoeda, string paraMoeda, Request request)
    {
        string uri = ($"{deMoeda}-{paraMoeda}/1");
        var response = await httpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        var data = JsonSerializer.Deserialize<JsonElement[]>(json);
        decimal valor = data[0].GetProperty("high").GetDecimal();


        var cambioDTO = new CambioDTO()
        {
            MoedaOrigem = deMoeda,
            MoedaDestino = paraMoeda,
            TaxaConversao = valor,
            DataAtualizacao = DateTime.Now
        };

        return new Response<CambioDTO> ( 200, "Cambio obtido com sucesso", cambioDTO );
    }
}
