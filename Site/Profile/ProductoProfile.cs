using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Profile
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<>(ProductoDTO, Producto);
        }
    }
}
