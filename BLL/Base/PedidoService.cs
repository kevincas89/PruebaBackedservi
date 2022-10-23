using BLL.Interface;
using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Base
{
    public class PedidoService : GenericServices<Pedido>, IPedidoService
    {
        public PedidoService(IGenericRepository<Pedido> genericRepository, DAL.Interface.IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }
    }
}
