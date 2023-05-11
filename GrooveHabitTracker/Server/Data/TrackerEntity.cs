using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrooveHabitTracker.Server.Data
{
    public class TrackerEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ConfigurationEntity))]
        public int ConfigId { get; set; }
        public virtual ConfigurationEntity ConfigurationEntity { get; set; }

        [Required]
        public bool TaskCompleted { get; set; }

        public string Notes { get; set; }
    }
}
