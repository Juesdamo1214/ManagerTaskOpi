using Api.Injections;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskContext>(options =>
                options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Api").UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion21)), ServiceLifetime.Transient);

builder.Inject();
builder.Services.AddCors(options => options.AddPolicy("AllowWebapp",

builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

app.UseCors("AllowWebapp");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
