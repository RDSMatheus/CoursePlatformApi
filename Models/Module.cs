using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursePlatform.Models
{
    [Table("Module")]   
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
    }
}
