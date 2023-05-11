using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrooveHabitTracker.Server.Data
{
    public class ConfigurationEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(HabitEntity))]
        public int HabitId { get; set; }
        public virtual HabitEntity HabitEntity { get; set; }

        [Required]
        public string Frequency { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

    }
}
