using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Profiles
{
    public class MarcaProfile : Profile
    {
        public MarcaProfile()
        {
            CreateMap<MarcaDTO, Marca>();
        }
    }
}
