using ShopAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.ServerApp.Models
{
    public class Rewies
    {
        [Key]
        public int RewiesId { get; set; }
        [Required]
        [StringLength(maximumLength: 200,MinimumLength = 5,ErrorMessage ="Еррор:)")]
        public string TitleComments { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
        public virtual User User { get; set; }

        public virtual Product Product { get; set; }

    }
}
