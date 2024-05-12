using Application.Interface;
using Application.Repository;
using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FilterImportanceTask : IFilterImportanceTask
    {
        private readonly IRepository<TaskEntity> _repositoryTask;

        public FilterImportanceTask (IRepository<TaskEntity> repositoryTask)
        {
            _repositoryTask = repositoryTask;
        }
        IEnumerable<TaskEntity> IFilterImportanceTask.FilterImportanceTask(Importance importance)
        {
            IEnumerable<TaskEntity> getAllTask = _repositoryTask.GetAll();
            IEnumerable<TaskEntity> filteredTasks = getAllTask.Where(task => task.Importance == importance);
            return filteredTasks.ToList();
        }
    }
}
