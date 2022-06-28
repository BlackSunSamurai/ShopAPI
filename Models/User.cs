using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ShopAPI.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(maximumLength:20,MinimumLength = 2,ErrorMessage = "Название именни должно быть больше 2 символов")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Фамилия должно быть больше 2 символов")]
        public string Family { get; set; }
        public string Number { get; set; }
    }
}
