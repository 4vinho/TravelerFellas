namespace TravelerFellas;

public class PontoTuristico : BaseEntity
{
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public int DestinoId { get; set; }
    public Destino? Destino { get; set; }
}
