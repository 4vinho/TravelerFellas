namespace TravelerFellas;

public class Cambio
{
    public int Id { get; set; }
    public string? MoedaOrigem { get; set; }
    public string? MoedaDestino { get; set; }
    public decimal TaxaConversao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
