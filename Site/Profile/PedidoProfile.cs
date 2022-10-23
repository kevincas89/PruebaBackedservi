using AutoMapper;
using Entity;
using Site.Models;

namespace Site.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMapp<PedidoDTO,Pedido>();
        }
    }
}
