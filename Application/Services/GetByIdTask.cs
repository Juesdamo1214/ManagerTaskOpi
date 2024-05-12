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
    public class GetByIdTask : IGetByIdTask
    {
        private readonly IRepository<TaskEntity> _repository;

        public GetByIdTask (IRepository<TaskEntity> repository)
        {
            _repository = repository;
        }

        TaskEntity IGetByIdTask.GetByIdTask(string id)
        {
            return _repository.GetById(id);
        }
    }
}
