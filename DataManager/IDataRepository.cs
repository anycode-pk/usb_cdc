using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace DataManager
{
    /// <summary>
    /// Interfejs dla repozytoriów, definiuje podstawowe funkcje.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataRepository<T> 
    {
        T Get(int id);
        IList<T> GetAll();
        void InsertOrUpdate(T item);
        bool Remove(T item);
        void RejectChanges(T item);
    }
}
