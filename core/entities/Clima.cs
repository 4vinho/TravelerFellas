namespace TravelerFellas;

public class Clima : BaseEntity
{
    public int DestinoId { get; set; }
    public Destino? Destino { get; set; }
    public decimal TemperaturaAtual { get; set; }
    public decimal SensacaoTermica { get; set; }
    public int Umidade { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataHoraConsulta { get; set; }
}
