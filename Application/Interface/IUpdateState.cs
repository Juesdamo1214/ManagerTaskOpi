using Domain.Enums;
using Domain.Models;

namespace Application.Interface
{
    public interface IUpdateState
    {
        public TaskEntity UpdateStateTask(string id, Status status);
    }
}
