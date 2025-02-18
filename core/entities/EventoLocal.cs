namespace TravelerFellas;

public class EventoLocal
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string? Localizacao { get; set; }
    public int DestinoId { get; set; }
    public Destino? Destino { get; set; }
}
