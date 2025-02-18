namespace TravelerFellas;

public class CambioDTO
{
    public string? MoedaOrigem { get; set; }
    public string? MoedaDestino { get; set; }
    public decimal TaxaConversao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
