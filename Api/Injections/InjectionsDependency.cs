﻿using Application.Interface;
using Application.Repository;
using Application.Services;
using Domain.Models;
using Infrastructure.Repository;
using Infrastructure.SendGrind;
using System.Data;

namespace Api.Injections
{
    public static class InjectionsDependency
    {
        public static void Inject(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ICreateTask, CreateTask>();
            builder.Services.AddTransient<IGetAllTask, GetAllTask>();
            builder.Services.AddTransient<IGetByIdTask, GetByIdTask>();
            builder.Services.AddTransient<IDeleteTask, DeleteTask>();
            builder.Services.AddTransient<IUpdateTask, UpdateTask>();
            builder.Services.AddTransient<IUpdateState, UpdateStateTask>();
            builder.Services.AddTransient<IFilterImportanceTask, FilterImportanceTask>();
            builder.Services.AddScoped<IRepository<TaskEntity>, TaskRepository<TaskEntity>>();

            builder.Services.AddHostedService<WorkerServices>();

            builder.Services.AddTransient<ISendNotificationTask>(it =>
            {
                var apiKey = it.GetRequiredService<IConfiguration>().GetValue<string>("ApiEmailKey");
                return new SendGrind(apiKey!);
            });
        }
    }
}
