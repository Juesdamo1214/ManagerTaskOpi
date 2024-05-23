using Application.Interface;
using Application.Repository;
using Domain.Enums;
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
        TaskEntity IUpdateTask.UpdateTask(string id, string title, Importance importance, DateTime expiredDate, string description)
        {
                TaskEntity taskEntity = _repositoryTask.GetById(id);

                taskEntity.Title = title;
                taskEntity.Importance = importance;
                taskEntity.ExpirationDate = expiredDate;
                taskEntity.Description = description;

                return _repositoryTask.Update(taskEntity);
        }
    }
}
