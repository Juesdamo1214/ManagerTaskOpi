using Domain.Enums;

namespace Domain.Models
{
    public class TaskEntity
    {
        public string? IdTask { get; set; }
        public string? IdUser { get; set; }
        public string? Title { get; set; }
        public Status Status { get; set; }
        public Importance Importance { get; set; }
        public DateTime  ExpirationDate { get; set; }
        public string? Description { get; set; }
        public virtual User? User { get; set; }
    }
}
