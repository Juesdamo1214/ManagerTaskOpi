using Domain.Enums;

namespace Api.Controllers.Models
{
    public class ModelCreateTask
    {
        public string? Title { get; set; }
        public Importance Importance { get; set; }
        public DateTime ExpiredTime { get; set; }
        public string? Description { get; set; }
    }
}
