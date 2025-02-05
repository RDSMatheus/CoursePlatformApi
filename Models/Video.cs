using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursePlatform.Models
{
    [Table("Videos")]
    public class Video
    {
        [Key]
        public int VideoId  { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        [Required]
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(300)]
        public string? Url { get; set; }
        public int ModuleId { get; set; }
        public Module? Module { get; set; }

    }
}
