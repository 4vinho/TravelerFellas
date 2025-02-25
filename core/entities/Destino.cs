namespace TravelerFellas;

public class Destino : BaseEntity
{
    public string? Nome { get; set; }
    public string? Pais { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
