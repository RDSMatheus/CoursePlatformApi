using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursePlatform.Models
{
    [Table("Courses")]
    public class Course
    {
        public Course () { 
            Modules = new List<Module> ();
        }
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [Required]
        [StringLength(300)]
        public string? Description { get; set; }
        [Required]
        [StringLength(40)]
        public string? Price { get; set; }
        public ICollection<Module> Modules { get; set; }
        public bool Lifetime { get; set; } = false;
        public bool Premium { get; set; } = false;

    }
}
