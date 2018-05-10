using App.Data;
using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UnitOfWok
{
    public class UnitOfWorkApp : UnitOfWorkGeneric<TaskModel> , IUnitOfWorkGeneric
    {
         
    }
}
