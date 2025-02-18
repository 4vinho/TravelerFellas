namespace TravelerFellas;

public class NotificacaoDTO
{
    public int UsuarioId { get; set; }
    public TipoNotificacao TipoNotificacao { get; set; }
    public string? Mensagem { get; set; }
    public DateTime DataEnvio { get; set; }
    public bool Lida { get; set; }
}
