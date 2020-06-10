using LetsGetMotivated.DAL.Interface;
using LetsGetMotivated.Logic.Interface;
using LetsGetMotivated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsGetMotivated.Logic
{
    public class TasksLogic : ITasksLogic
    {

        private readonly ITasksContext _tasksContext;

        public TasksLogic(ITasksContext tasksContext)
        {
            _tasksContext = tasksContext;
        }

        public TasksLogic()
        {}

        public Task<Tasks> Add(Tasks task)
        {
            return _tasksContext.Add(task);
        }

        public Task<bool> Delete(int id)
        {
            return _tasksContext.Delete(id);
        }

        public Task<List<Tasks>> GetAll()
        {
            return _tasksContext.GetAll();


        }

        public Task<Tasks> GetById(int id)
        {
            return _tasksContext.GetById(id);
        }

        public Task<Tasks> Update(Tasks task)
        {
            return _tasksContext.Update(task);
        }
    }
}
