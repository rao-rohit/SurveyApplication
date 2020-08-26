using System;
using System.Collections.Generic;
using System.Text;

namespace CSDALContract
{
    public interface IDAL<T> where T : class
    {
        /// <summary>
        /// Interface for Data Access Layer.
        /// The Add / Update Method are in-memory Add/Update. To do final save, we should call the Save Method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
     
            void Add(T entity);

            void Update(T entity);

            List<T> Get();

            T Get(T entity);

            void Save();
        
    }
}
