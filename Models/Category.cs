using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:40,MinimumLength = 4,ErrorMessage ="Не корректно введенно имя категории")]
        public string NameCategory { get; set; }
    }
}
