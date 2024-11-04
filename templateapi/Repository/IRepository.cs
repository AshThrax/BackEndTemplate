using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Repository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// get all entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAll(int page , int pageSize);
        /// <summary>
        /// get a page of T entities but filtered
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllFiltered(int page , int pageSize,Expression<Func<T,bool>> predicate);
        /// <summary>
        /// get entities by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetbyId(int id);
        /// <summary>
        /// get a specific data from the application with a filter
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
         Task<T> GetbyFilter(Expression<Func<T,bool>> predicate);
         /// <summary>
         /// delete entities
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        bool Remove(int id);
        T AddAsync();
        /// <summary>
        /// update data 
        /// </summary>
        /// <returns></returns>
        T UpdateAsync();
        /// <summary>
        /// save database
        /// </summary>
        /// <returns></returns>
        Task<int> Save();   
        /// <summary>
        /// getting data base on predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> SelecteAsync(Expression<Func<T,bool>> predicate);
        
    }
}