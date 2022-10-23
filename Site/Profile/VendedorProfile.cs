using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Profile
{
    public class VendedorProfile : Profile
    {
        public VendedorProfile()
        {
            CreateMap<>(VendedorDTO, Vendedor);
        }
    }
}
