using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace templateapi.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
         /// <summary>
        /// get all entities
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<T>> GetAll(int page , int pageSize)
        {
            try
            {

            }
            catch(Exception ex)
            {

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

            }
            catch(Exception ex)
            {
                
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

            }
            catch(Exception ex)
            {
                
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

            }
            catch(Exception ex)
            {
                
            }
        }
        public T AddAsync()
        {
            try
            {

            }
            catch(Exception ex)
            {
                
            }
        }
        /// <summary>
        /// update data 
        /// </summary>
        /// <returns></returns>
        public T UpdateAsync()
        {
            try
            {

            }
            catch(Exception ex)
            {
                
            }
        }
        /// <summary>
        /// proceed to a save int the database
        /// </summary>
        /// <returns></returns>
        public Task<int> Save()
        {
            try
            {

            }
            catch(Exception ex)
            {
                
            }
        }
        /// <summary>
        /// getting data base on predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<T> SelecteAsync(Expression<Func<T,bool>> predicate)
        {
            try
            {

            }
            catch(Exception ex)
            {
                
            }
        }
    }
}