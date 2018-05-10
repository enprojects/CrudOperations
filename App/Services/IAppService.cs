using App.Models;
using System.Collections;
using System.Collections.Generic;

namespace App.Services
{
    public interface IAppService
    {
        IEnumerable<TaskModel> GetAll();
    }
}