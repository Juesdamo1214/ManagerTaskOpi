using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ISendNotificationTask
    {
        Task SendNotificationTask(string email, string contentText, string user);
    }
}
