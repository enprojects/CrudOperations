using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public interface IUnitOfWorkGeneric
    {
        int Save();
        IGenericRepo<Tentity> GetRepositoryType<Tentity>() where Tentity : class;

    }
}
