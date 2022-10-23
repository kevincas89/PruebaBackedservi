using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class MarcaRepository : GenericRepository<Marca>, IMarcaRepository
    {
        public MarcaRepository(ServiDrinkContext serviDrinkContext) : base(serviDrinkContext)
        {
        }
    }
}
