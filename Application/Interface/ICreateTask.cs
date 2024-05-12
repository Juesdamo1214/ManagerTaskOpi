using Domain.Enums;
using Domain.Models;

namespace Application.Interface
{
    public interface ICreateTask
    {
        public TaskEntity CreateTask (string title, Importance importance, DateTime expiredDate, string description );
    }
}
