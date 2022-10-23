using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class UnitOfWork : IUnitOfWork
    {

        public ServiDrinkContext Context => throw new NotImplementedException();


        public void Commit()
        {
            Context.SaveChanges();        
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
