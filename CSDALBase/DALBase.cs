using System;
using System.Collections.Generic;
using System.Text;

namespace CSDALBase
{
    /// <summary>
    /// Abstract class for contating common things, Common for DAL (Ado.net / EF) e.g. Connection String, CRUD / InMemory Methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class DALBase<T> : CSDALContract.IDAL<T>
             where T : class //T Should be a reference type
    {
        //List to hold inmemory data (Which is ready to get committed)
        protected List<T> lstNewDirtyData = new List<T>();

        protected string connectionString;

        public DALBase(string ConnectionString)
        {
            connectionString = ConnectionString;
        }

        /// The Add / Update Methods are virtual because EF or some other DAL techonoly can have better way of handing in-memmory data. So, 
        /// we are providing facility to override these methods.
        public virtual void Add(T entity)
        {
            lstNewDirtyData.Add(entity);
        }

        public virtual void Update(T entity)
        {
            lstNewDirtyData.Add(entity);
        }

        public virtual List<T> Get()
        {
            throw new NotImplementedException();
        }

        public virtual T Get(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

    }
}
