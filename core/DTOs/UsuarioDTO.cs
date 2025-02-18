namespace TravelerFellas;

public class UsuarioDTO
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public List<Destino>? DestinosFavoritos { get; set; }
}
