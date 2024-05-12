using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class TaskContext : DbContext 
    {
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<User> Users {  get; set; }

        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            //Database.EnsureCreated(); 
            //SeedData.Initialize(this);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskEntity>(tasksEntity =>
            {
                tasksEntity.ToTable("Tasks");
                tasksEntity.HasKey(t => t.IdTask);
                tasksEntity.Property(t => t.Title).HasMaxLength(50).IsRequired();
                tasksEntity.Property(t => t.Status).IsRequired();
                tasksEntity.Property(t => t.Description).HasMaxLength(50).IsRequired();
                tasksEntity.Property(t => t.Importance).IsRequired();
                tasksEntity.Property(t => t.ExpirationDate);

                tasksEntity.HasOne(t => t.User)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.IdUser).OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<User>(users =>
            {
                users.ToTable("Users");
                users.HasKey(user => user.IdUsers);
                users.Property(user => user.Name).HasMaxLength(50).IsRequired();
                users.Property(user => user.LastName).HasMaxLength(50).IsRequired();
                users.Property(user => user.Email).HasMaxLength(50).IsRequired();
                users.Property(user => user.Password).HasMaxLength(50).IsRequired();
            });
        }

    }
}
