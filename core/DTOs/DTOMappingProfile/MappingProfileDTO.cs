using AutoMapper;

namespace TravelerFellas;

public class MappingProfileDTO : Profile
{
    public MappingProfileDTO()
    {
        CreateMap<Cambio, CambioDTO>().ReverseMap();
        CreateMap<Clima, ClimaDTO>().ReverseMap();
        CreateMap<Destino, DestinoDTO>().ReverseMap();
        CreateMap<EventoLocal, EventoLocalDTO>().ReverseMap();
        CreateMap<Notificacao, NotificacaoDTO>().ReverseMap();
        CreateMap<PontoTuristico, PontoTuristicoDTO>().ReverseMap();
        CreateMap<Usuario, UsuarioDTO>().ReverseMap();
    }
}
