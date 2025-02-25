namespace TravelerFellas;

public class Cambio : BaseEntity
{
    public string? MoedaOrigem { get; set; }
    public string? MoedaDestino { get; set; }
    public decimal TaxaConversao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}
