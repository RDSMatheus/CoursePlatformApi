using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoursePlatform.Models
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(300)]
        public string? Email { get; set; }
        [Required]
        [StringLength(14)]
        public string? Cpf {  get; set; }
        [Required]
        [StringLength(300)]
        public string? Password { get; set; }
        public DateTime SignUpDate { get; set; }
        public bool PremiumAccess { get; set; } = false;
        public bool PaidAccess { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
