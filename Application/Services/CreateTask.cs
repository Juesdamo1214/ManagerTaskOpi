using Application.Interface;
using Application.Repository;
using Domain.Enums;
using Domain.Models;

namespace Application.Services
{
    public class CreateTask : ICreateTask
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public CreateTask ( IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }
        TaskEntity ICreateTask.CreateTask(string title, Importance importance, DateTime expiredDate, string description)
        {
            TaskEntity newTask = new()
            {
                IdTask = Guid.NewGuid().ToString(),
                IdUser = "9d1402c1-a62d-4c33-9873-9ab3ac5c50ad",
                Title = title,
                Status = Status.pending,
                Importance = importance,
                ExpirationDate = expiredDate,
                Description = description,

            };
            return _repositoryTask.Add(newTask);
        }
    }
}
