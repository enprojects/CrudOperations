using App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public  class UnitOfWorkGeneric<TEntity> : IUnitOfWorkGeneric where TEntity : class

    {  // to do generic uof
      //  private GenericRepo<TaskModel> taskModelRepo;
        
        private AppContext<TEntity> _ctx;
        private Dictionary<Type, object> dic;

        public UnitOfWorkGeneric()
        {
            _ctx = new AppContext<TEntity>();   // new AppContext<TaskModel>();
            dic = new Dictionary<Type, object>();
        }

        public IGenericRepo<Tentity> GetRepositoryType<Tentity>() where Tentity : class
        {
            if (dic.ContainsKey(typeof(Tentity)))
            {
                return dic[typeof(Tentity)] as IGenericRepo<Tentity>;
            }

            dic.Add(typeof(Tentity), new GenericRepo<Tentity>(_ctx));
            return dic[typeof(Tentity)] as IGenericRepo<Tentity>;
        }
         
        //public GenericRepo<TaskModel> TaskModelRepo
        //{
        //    get
        //    {
        //        if (taskModelRepo == null)
        //        {
        //            this.taskModelRepo = new GenericRepo<TaskModel>(_ctx);
        //        }
        //        return this.taskModelRepo;
        //    }
        //}

        public int  Save()
        {
             return _ctx.SaveChanges();
        }
    }
}
