using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// get all entities
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetAll(int page , int pageSize)
        {
            try
            {
                return _context.Set<T>()
                                .Skip((page -1) * pageSize)
                               .Take(pageSize)
                               .ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }
        /// <summary>
        /// get a page of T entities but filtered
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetAllFiltered(int page , int pageSize,Expression<Func<T,bool>> predicate)
          {
            try
            {
                IQueryable<T> query = _context.Set<T>();
                if(predicate == null)
                {
                    query.where(predicate);
                }
               return query.Skip((page -1) * pageSize)
                           .Take(pageSize)
                           .ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// get entities by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<T> GetbyId(int id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// get a specific data from the application with a filter
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<T> GetbyFilter(Expression<Func<T,bool>> predicate)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();
                if(predicate == null)
                {
                    query.where(predicate);
                }
               return query.FirstOrDefault();
            }
            catch(Exception ex)
            {
                
            }
        }
         /// <summary>
         /// delete entities
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        public bool Remove(int id)
        {
            try
            {
                T EntityToremove = _context.Set<T>().Find(id);
                if(remove != null)
                {
                    _context.remove(EntityToremove);
                }
            }
            catch(Exception ex)
            {
                throw ;
            }
        }
        /// <summary>
        /// add data of type t 
        /// </summary>
        /// <returns></returns>
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
            
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// update data 
        /// </summary>
        /// <returns></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// proceed to a save int the database
        /// </summary>
        /// <returns></returns>
        public async Task<int> Save()
        {
            try
            {
                return -_context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// getting data base on predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        publicb async Task<T> SelecteAsync(Expression<Func<T,bool>> predicate)
        {
            try
            {
                IQueryable<T> query = _context.Set<T>();
                if(predicate == null)
                {
                    query.where(predicate);
                }
                return query.ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}