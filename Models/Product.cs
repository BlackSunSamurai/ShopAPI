using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100,MinimumLength = 5,ErrorMessage = "Не корректно введено имя товара")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IfExist { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
