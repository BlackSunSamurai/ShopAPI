using System;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public string OrderStatus { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PaymentMethod { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }


    }
}
