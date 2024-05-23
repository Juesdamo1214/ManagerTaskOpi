using Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class WorkerServices : BackgroundService
    {
        private readonly ILogger<WorkerServices> _logger;
        private readonly ISendNotificationTask _sendNotificationTask;

        public WorkerServices(ILogger<WorkerServices> logger, ISendNotificationTask sendNotificationTask)
        {
            _logger = logger;
            _sendNotificationTask = sendNotificationTask;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    await _sendNotificationTask.SendNotificationTask("juesdamo1412@gmail.com", "Hola", "Juesdamo");

            //    await Task.Delay(5000, stoppingToken);
            //}
        }
    }
}
