using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Product : BaseClass
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public int Stock { get; set; }
        public bool InStock { get; set; }
        public string? Brand { get; set; }
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Cost { get; set; }
        public string? Image { get; set; }
    }
}