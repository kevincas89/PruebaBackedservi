using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IUnitOfWork : IDisposable
    {

        ServiDrinkContext Context { get; }
        void Commit();

    }
}
