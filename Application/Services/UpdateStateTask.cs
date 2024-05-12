using Application.Interface;
using Application.Repository;
using Domain.Enums;
using Domain.Models;

namespace Application.Services
{
    public class UpdateStateTask : IUpdateState
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public UpdateStateTask (IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }

        TaskEntity IUpdateState.UpdateStateTask(string id, Status status)
        {
            TaskEntity task = _repositoryTask.GetById(id);
            task.Status = status;
            return _repositoryTask.Update(task);
        }
    }
}
