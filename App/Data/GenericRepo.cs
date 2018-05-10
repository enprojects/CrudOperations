using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class

    {
        #region Properties
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        #endregion
        #region ctors
        public GenericRepo(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        #endregion
        #region Interface method
        public IEnumerable<T> Get(Func<T, bool> func = null)
        {
            if (func != null)
            {
                return _context.Set<T>().Where(func).ToList();
            }

            return _dbSet.ToList();
        }
        public virtual void Add(T obj)
        {
            _dbSet.Add(obj);
           // return Save();
        }
        public virtual void Remove(T obj)
        {
            _dbSet.Remove(obj);
           // return Save();
        }
        public virtual void  Update()
        {
            _context.Entry(typeof(T)).State = System.Data.Entity.EntityState.Modified;     
          //  return Save();
        }

         
        //public int Save()
        //{
        //    return _context.SaveChanges();
        //}

        #endregion
    }
}
