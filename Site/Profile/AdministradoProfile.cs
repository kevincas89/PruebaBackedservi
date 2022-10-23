using Entity;
using Site.Models;
using AutoMapper;

namespace Site.Profile
{
    public class AdministradoProfile : Profile
    {
        public AdministradoProfile()
        {
            CreateMap<AdministradorDTO, Administrador>();
        }
    }
}
