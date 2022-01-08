using System.ComponentModel.DataAnnotations;

namespace LaceUp.Models
{
    public class ShoppingBag
    {
        public int Id { get; set; }

        [Required]
        public string Shoe { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
