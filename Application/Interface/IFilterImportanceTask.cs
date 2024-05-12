using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IFilterImportanceTask
    {
        public IEnumerable<TaskEntity> FilterImportanceTask(Importance importance);
    }
}
