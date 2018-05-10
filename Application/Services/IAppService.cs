using Application.Models;
using System.Collections;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IAppService
    {
        IEnumerable<TaskModel> GetAll();
    }
}