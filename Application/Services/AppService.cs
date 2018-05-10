using System;
using System.Collections.Generic;
using System.Text;
using Application.Data;
using Application.Models;

namespace Application.Services
{
    public class AppService : IAppService
    {

        private UnitOfWork uow;
        public AppService()
        {
            uow = new UnitOfWork();
        }

        public IEnumerable<TaskModel> GetAll()
        {
            return uow.TaskModelRepo.Get();
        }
    }
}
