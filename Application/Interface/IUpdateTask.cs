using Domain.Enums;
using Domain.Models;

namespace Application.Interface
{
    public interface IUpdateTask
    {
        TaskEntity UpdateTask (string id, string title, Importance importance, DateTime expiredDate, string description);
    }
}
