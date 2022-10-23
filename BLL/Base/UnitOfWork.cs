using BLL.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        public ServiDrinkContext Context => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
