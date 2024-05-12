using Application.Interface;
using Application.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UpdateTask : IUpdateTask
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public UpdateTask (IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }
        TaskEntity IUpdateTask.UpdateTask(string id,  TaskEntity taskEntityNew)
        {
                TaskEntity taskEntity = _repositoryTask.GetById(id);
                taskEntity = taskEntityNew;
                return _repositoryTask.Update(taskEntity);
        }
    }
}
