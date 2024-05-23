using Api.Controllers.Models;
using Application.Interface;
using Domain.Enums;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ICreateTask _createTask;
        private readonly IGetAllTask _getAllTask;
        private readonly IGetByIdTask _getByIdTask;
        private readonly IDeleteTask _deleteByIdTask;
        private readonly IUpdateTask _updateByIdTask;
        private readonly IUpdateState _updateState;
        private readonly IFilterImportanceTask _filterImportanceTask;

        public TaskController(ICreateTask createTask, IGetAllTask getAllTask, IGetByIdTask getByIdTask, IDeleteTask deleteByIdTask, IUpdateTask updateByIdTask, IUpdateState updateState, IFilterImportanceTask filterImportanceTask)
        {
            _createTask = createTask;
            _getAllTask = getAllTask;
            _getByIdTask = getByIdTask;
            _deleteByIdTask = deleteByIdTask;
            _updateByIdTask = updateByIdTask;
            _updateState = updateState;
            _filterImportanceTask = filterImportanceTask;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<TaskEntity> GetAllTask()
        {
            return _getAllTask.GetAll();
        }

        // GET api/<TaskController>/5
        [HttpGet("ById/{id}")]
        public TaskEntity GetByIdTask(string id)
        {
            return _getByIdTask.GetByIdTask(id);
        }

        [HttpGet("FilterImportance/{importance}")]

        public IEnumerable<TaskEntity> GetFilterImportanceTask(Importance importance)
        {
            return _filterImportanceTask.FilterImportanceTask(importance);
        }

        // POST api/<TaskController>
        [HttpPost]
        public TaskEntity Post([FromBody] ModelCreateTask taskEntity)
        {
            return _createTask.CreateTask(taskEntity.Title, taskEntity.Importance, taskEntity.ExpiredTime, taskEntity.Description);
        }

        // PUT api/<TaskController>/5
        [HttpPut("UpdateState/{id}")]

        public TaskEntity PutStateTask(string id, [FromBody] Status state)
        {
            return _updateState.UpdateStateTask(id, state);
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public TaskEntity Put(string id, [FromBody] ModelCreateTask taskEntity)
        {
            return _updateByIdTask.UpdateTask(id, taskEntity.Title, taskEntity.Importance, taskEntity.ExpiredTime, taskEntity.Description);
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _deleteByIdTask.DeleteTask(id);
        }
    }
}
