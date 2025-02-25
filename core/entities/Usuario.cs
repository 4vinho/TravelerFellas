namespace TravelerFellas;

public class Usuario : BaseEntity
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public DateTime DataCriacao { get; set; }
    public List<Destino>? DestinosFavoritos { get; set; }
}
