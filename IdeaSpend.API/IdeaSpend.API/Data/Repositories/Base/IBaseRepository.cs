﻿using System.Threading.Tasks;

namespace IdeaSpend.API
{
    public interface IBaseRepository
    {
        /// <summary>
        /// Add entity to repository for save, update and so on
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        void Add<T> ( T entity ) where T : class;

        /// <summary>
        /// Delete entity object from database
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        void Delete<T> ( T entity ) where T : class;

        /// <summary>
        /// Modify current object with new values
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        void Update<T> ( T entity ) where T : class;

        /// <summary>
        /// Adding entity from repository to database
        /// </summary>
        /// <returns></returns>
        Task<bool> SaveAllAsync ();

        /// <summary>
        /// Adding entity from repository to database
        /// </summary>
        /// <returns></returns>
        bool SaveAll();
    }
}