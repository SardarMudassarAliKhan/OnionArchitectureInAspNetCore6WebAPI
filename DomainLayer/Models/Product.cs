using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Varient { get; set; }
        public string? SKU { get; set; }
        public string? Quantity { get; set; }
        public int? Age { get; set; }
    }
}
