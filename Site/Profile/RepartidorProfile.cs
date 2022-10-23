using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Profile
{
    public class RepartidorProfile : Profile
    {
        public RepartidorProfile()
        {
            CreateMap<>(RepartidorDTO, Repartidor);
        }
    }
}
