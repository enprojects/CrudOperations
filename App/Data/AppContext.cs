
using App.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
   public  class AppContext<T> :DbContext where T : class    
    {

        public AppContext() 
            :base("name=AppCtx")
        {
                
        }

      public virtual DbSet<T> _EntityTable { get; set; }
       // public virtual DbSet<TaskModel> TaskModels { get; set; }
        
    }
}
