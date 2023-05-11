using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrooveHabitTracker.Server.Data
{
    public class UserProfileEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [ForeignKey(nameof(TrackerEntity))]
        public int InProgress { get; set; }
        public virtual TrackerEntity TrackerEntity { get; set; }
    }
}
