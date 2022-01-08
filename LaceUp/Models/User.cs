using System.ComponentModel.DataAnnotations;

namespace LaceUp.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
