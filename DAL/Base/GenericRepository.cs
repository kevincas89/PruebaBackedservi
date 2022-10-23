using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DAL.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly ServiDrinkContext serviDrinkContext;

        public GenericRepository(ServiDrinkContext serviDrinkContext)
        {
            this.serviDrinkContext = serviDrinkContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
           
                throw new Exception("The entity is null");
                serviDrinkContext.Set<TEntity>().Remove(entity);
                await serviDrinkContext.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await serviDrinkContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await serviDrinkContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            serviDrinkContext.Set<TEntity>().Add(entity);
            return entity;

        }

        public async Task<TEntity> Update(TEntity entity)
        {
            serviDrinkContext.Entry(entity).State = EntityState.Modified;
            return entity;

        }
    }



}
