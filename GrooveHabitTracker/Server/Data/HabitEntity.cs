using System.ComponentModel.DataAnnotations;

namespace GrooveHabitTracker.Server.Data
{
    public class HabitEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HabitTitle { get; set; }
        public string Description { get; set; }

    }
}
