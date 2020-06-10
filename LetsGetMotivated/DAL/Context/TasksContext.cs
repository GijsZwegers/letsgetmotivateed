using LetsGetMotivated.DAL.Interface;
using LetsGetMotivated.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsGetMotivated.DAL.Context
{
    public class TasksContext : ITasksContext
    {
        private ApiDBContext _context;

        public TasksContext(ApiDBContext context)
        {
            _context = context;
        }

        public async Task<Tasks> Add(Tasks task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();

            if (await _context.Tasks.ContainsAsync(task))
            {
                return task;
            }

            return null;
        }

        public async Task<bool> Delete(int id)
        {
            var selectedTask = await _context.Tasks.FirstOrDefaultAsync(o => o.Id == id);

            _context.Tasks.Remove(selectedTask);

            if (await _context.Tasks.ContainsAsync(selectedTask))
            {
                return false;
            }

            return true;
        }

        public async Task<List<Tasks>> GetAll()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Tasks> GetById(int id)
        {
            return await _context.Tasks.FirstOrDefaultAsync(task => task.Id == id);
        }

        public async Task<Tasks> Update(Tasks task)
        {
            var editobject = await _context.Tasks.FirstOrDefaultAsync(o => o.Id == task.Id);
            _context.Entry(editobject).CurrentValues.SetValues(task);

            await _context.SaveChangesAsync();

            return editobject;
        }
    }
}
