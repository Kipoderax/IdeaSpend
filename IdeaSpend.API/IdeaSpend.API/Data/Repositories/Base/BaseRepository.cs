﻿using System.Threading.Tasks;

namespace IdeaSpend.API
{
    /// <summary>
    /// Base functionality to manage entities
    /// </summary>
    public class BaseRepository
    {
        #region Private Members

        /// <summary>
        /// The scope application data context
        /// </summary>
        protected readonly IdeaSpendContext _dataContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="dataContext">The injected context</param>
        public BaseRepository ( IdeaSpendContext dataContext )
        {
            _dataContext = dataContext;
        }

        #endregion

        #region Implemented Methods

        /// <summary>
        /// Add entity to repository for save, update and so on
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        public void Add<T> ( T entity ) where T : class
        {
             _dataContext.Add( entity );
        }

        /// <summary>
        /// Delete entity object from database
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        public void Delete<T> ( T entity ) where T : class
        {
            _dataContext.Remove( entity );
        }

        /// <summary>
        /// Modify current object with new values
        /// </summary>
        /// <typeparam name="T">Type class</typeparam>
        /// <param name="entity">The entity class</param>
        public void Update<T> ( T entity ) where T : class
        {
            _dataContext.Update( entity );
        }

        /// <summary>
        /// Adding entity from repository to database
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SaveAllAsync ()
        {
            // Greater than zero means that something with success saved to database
            return await _dataContext.SaveChangesAsync() > 0;
        }

        #endregion
    }
}