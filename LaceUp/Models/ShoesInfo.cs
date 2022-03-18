using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaceUp.Models
{
    public class ShoesInfo
    {
        public int Id { get; set; }
        [Required]
        public string ShoeName { get; set; }
        [Required]
        public string ShoeCategory { get; set; }
        [Required]
        public int ShoePrice { get; set; }
    }
}
