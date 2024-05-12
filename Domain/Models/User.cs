using Domain.Enums;

namespace Domain.Models
{
    public class User
    {
        public string? IdUsers { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public PreferenceNotification Notification { get; set; }
        public IEnumerable<TaskEntity>? Tasks { get; set; }
    }
}
