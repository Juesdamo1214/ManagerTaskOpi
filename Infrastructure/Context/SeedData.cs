using Domain.Models;

namespace Infrastructure.Context
{
    public static class SeedData
    {
        public static void Initialize(TaskContext context)
        {

            if (context.Users.Any())
            {
                return;
            }

            var user = new User
            {
                IdUsers = Guid.NewGuid().ToString(),
                Name = "Esteban",
                LastName = "Montoya",
                Email = "esteban@example.com",
                Password = "123456"
            };

            context.Users.Add(user);
            context.SaveChanges(); 
        }
    }
}
