using BLL.Interface;
using BLL.Response;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUnitOfWork = DAL.Interface.IUnitOfWork;

namespace BLL.Base
{
    public class GenericServices<TEntity> : IGenericService<TEntity> where TEntity : class
    {


        private IGenericRepository<TEntity> _genericRepository;
        private IUnitOfWork _unitOfWork;
       

        public GenericServices(IGenericRepository<TEntity> genericRepository, IUnitOfWork unitOfWork)
        {
            _genericRepository = genericRepository;
           _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponse<TEntity>> Delete(int id)
        {
            try
            {
                var entity = await _genericRepository.GetById(id);
                if (entity != null)
                {
                    await _genericRepository.Delete(id);
                    _unitOfWork.Commit();
                    return new GenericResponse<TEntity>(entity);
                }
                return new GenericResponse<TEntity>($"No se encontro el registro");
            }
            catch(Exception e){ _unitOfWork.Dispose();
                return new GenericResponse<TEntity>($"Error de consulta: error {e.Message}");
                
            }
        }

        public async Task<GenericResponse<TEntity>> GetAll()
        {                                        

            try
            {
                IEnumerable<TEntity> entities = await _genericRepository.GetAll();
                if(entities != null)
                {
                    return new GenericResponse<TEntity>(entities);
                }
                return new GenericResponse<TEntity>($"No se encotraron registros");
            }
            catch(Exception e) { _unitOfWork.Dispose(); return new GenericResponse<TEntity>($"Error de consulta: error {e.Message}"); }
        
        }

        public async Task<GenericResponse<TEntity>> GetById(int i)
        {
            try
            {
                var Entity = await _genericRepository.GetById(i);
                if(Entity != null)
                {
                    return new GenericResponse<TEntity>(Entity);
                }
                return new GenericResponse<TEntity>($"No se encontro registro");
            }
            catch (Exception e) { _unitOfWork.Dispose(); return new GenericResponse<TEntity>($"Error de consulta: error {e.Message}"); }
        }

        public async Task<GenericResponse<TEntity>> Insert(TEntity entity,int id)
        {
            try
            {
                var entityFind = _genericRepository.GetById(id);
                if (entityFind == null)
                {

                    await _genericRepository.Insert(entity);
                    _unitOfWork.Commit();
                    return new GenericResponse<TEntity>(entity);
                }
                return new GenericResponse<TEntity>($"Este registro ya existe");
            }
            catch (Exception e) { _unitOfWork.Dispose(); return new GenericResponse<TEntity>($"Error de registro: error {e.Message}"); }
        }

        public async Task<GenericResponse<TEntity>> Update(TEntity entity, int id)
        {
            try
            {
                var entityFind = _genericRepository.GetById(id);
                if(entityFind != null)
                {
                    await _genericRepository.Update(entity);
                    _unitOfWork.Commit();
                    return new GenericResponse<TEntity>(entity);
                }
                return new GenericResponse<TEntity>($"Registro no encontrado");
            }
            catch (Exception e) { _unitOfWork.Dispose(); return new GenericResponse<TEntity>($"Error de registro: error {e.Message}"); }
        }
    }
}
