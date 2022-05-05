using System.ComponentModel.DataAnnotations;

namespace Unit7_EFCore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }
    }
}

