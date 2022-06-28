using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(maximumLength: 100,MinimumLength = 5,ErrorMessage = "Не корректно введено имя товара")]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IfExist { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public virtual Category Category { get; set; }

    }
}
