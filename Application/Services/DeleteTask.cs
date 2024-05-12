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
    public class DeleteTask : IDeleteTask
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public DeleteTask(IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }

        void IDeleteTask.DeleteTask(string id)
        {   
            _repositoryTask.Delete(id);
        }
    }
}
