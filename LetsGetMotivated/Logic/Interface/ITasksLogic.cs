using LetsGetMotivated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsGetMotivated.Logic.Interface
{
    public interface ITasksLogic
    {
        Task<Tasks> Add(Tasks task);
        Task<bool> Delete(int id);
        Task<Tasks> Update(Tasks task);
        Task<List<Tasks>> GetAll();
        Task<Tasks> GetById(int id);
    }
}
