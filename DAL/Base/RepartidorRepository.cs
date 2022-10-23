﻿using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class RepartidorRepository : GenericRepository<Repartidor>, IRepartidorRepository
    {
        public RepartidorRepository(ServiDrinkContext serviDrinkContext) : base(serviDrinkContext)
        {
        }
    }
}
