namespace TravelerFellas;

public class Notificacao : BaseEntity
{
    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
    public TipoNotificacao TipoNotificacao { get; set; }
    public string? Mensagem { get; set; }
    public DateTime DataEnvio { get; set; }
    public bool Lida { get; set; }
}
