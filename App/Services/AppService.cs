using System;
using System.Collections.Generic;
using System.Text;
using App.Data;
using App.Models;
using App.Services;
using App.UnitOfWok;

namespace App.Services
{

    public class AppService : IAppService
    {

        private IUnitOfWorkGeneric _uow;

        public AppService(IUnitOfWorkGeneric uow)
        {
            _uow = uow;
        }

        public IEnumerable<TaskModel> GetAll()
        {
            //  return _uow.TaskModelRepo.Get();

            var test = _uow.GetRepositoryType<TaskModel>();

            var blblb = test.Get();
            return blblb;

        }

    }
}
