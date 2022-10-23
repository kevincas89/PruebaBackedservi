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
    public class VendedorService : GenericServices<Vendedor>, IVendedorService
    {
        public VendedorService(IGenericRepository<Vendedor> genericRepository, DAL.Interface.IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }
    }
}
