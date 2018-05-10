using System;
using System.Collections.Generic;

namespace App.Data
{
    public interface IGenericRepo<T>  where T : class
    {
        IEnumerable<T> Get(Func<T, bool> func = null);
        void Add(T obj);
        void Update();
       // int Save();
    }
}