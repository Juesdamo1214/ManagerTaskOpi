using Application.Interface;
using Application.Repository;
using Domain.Models;

namespace Application.Services
{
    public class GetAllTask : IGetAllTask
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public GetAllTask (IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }
        public IEnumerable<TaskEntity> GetAll()
        {
            return _repositoryTask.GetAll();
        }
    }
}
