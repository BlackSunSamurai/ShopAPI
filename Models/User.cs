using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:20,MinimumLength = 2,ErrorMessage = "Название именни должно быть больше 2 символов")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Фамилия должно быть больше 2 символов")]
        public string Family { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Не корректно указан адресс электроной почты")]
        public string Email { get; set; }
        public string Number { get; set; }
        [Required]
        [StringLength (maximumLength: 20, MinimumLength = 2, ErrorMessage = "Не верно введён логин")]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 15,MinimumLength = 6,ErrorMessage = "Пароль должен быть больше 6 символов")]
        public string Password { get; set; }

        
    }
}
