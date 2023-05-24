using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class registerDto
    {
        [Required,MaxLength(30)]
        public string? Username { get; set; }
        [Required,MaxLength(255)]
        public string? Password { get; set; }
    }
}
