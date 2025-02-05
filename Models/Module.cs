
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursePlatform.Models
{
    [Table("Modules")]   
    public class Module
                
    {
        public Module() { 
            Videos = new List<Video>();
        }
        [Key]
        public int ModuleId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        [Required]
        [StringLength(300)]
        public string? Description { get; set; }
        public ICollection<Video>? Videos { get; set; }
        public int CourseId { get; set; }
        [Required]
        public Course? Course { get; set; }
    }
}
