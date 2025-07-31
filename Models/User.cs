using System.ComponentModel.DataAnnotations;

namespace SecureApiJwtAuth.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Username { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        [MaxLength(50)]
        public string Role { get; set; } = "User";
    }
}