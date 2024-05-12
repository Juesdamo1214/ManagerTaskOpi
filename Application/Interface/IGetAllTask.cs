using Domain.Models;

namespace Application.Interface
{
    public interface IGetAllTask
    {
        IEnumerable<TaskEntity> GetAll();
    }
}
