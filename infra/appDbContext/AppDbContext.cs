using Microsoft.EntityFrameworkCore;

namespace TravelerFellas;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Cambio> Cambio { get; set; } = null!;
    public DbSet<Clima> Clima { get; set; } = null!;
    public DbSet<Destino> Destino { get; set; } = null!;
    public DbSet<EventoLocal> EventoLocal { get; set; } = null!;
    public DbSet<Notificacao> Notificacao { get; set; } = null!;
    public DbSet<PontoTuristico> PontoTuristico { get; set; } = null!;
    public DbSet<Usuario> Usuario { get; set; } = null!;
}
