using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetsGetMotivated.Api.EntityModels;
using LetsGetMotivated.Logic.Interface;
using LetsGetMotivated.Models;
using Microsoft.AspNetCore.Mvc;

namespace LetsGetMotivated.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITasksLogic _taskslogic;

        public TasksController(ITasksLogic taskslogic)
        {
            _taskslogic = taskslogic;
        }

        [HttpPost("create")]
        public async Task<JsonResult> Create(TasksEntityModel task)
        {
            Tasks newtask = new Tasks(task.Id, task.Name, task.Description, task.StartDate, task.FinishedDate, task.PlannedDate);
            return new JsonResult(await _taskslogic.Add(newtask));
        }

        [HttpDelete("delete")]
        public async Task<JsonResult> Delete(int id)
        {
            return new JsonResult(await _taskslogic.Delete(id));
        }

        [HttpPost("update")]
        public async Task<JsonResult> Update(TasksEntityModel task)
        {
            Tasks newtask = new Tasks(task.Id, task.Name, task.Description, task.StartDate, task.FinishedDate, task.PlannedDate);
            return new JsonResult(await _taskslogic.Update(newtask));
        }

        [HttpGet("get")]
        public async Task<JsonResult> GetAll()
        {
            return new JsonResult(await _taskslogic.GetAll());

        }
    }
}