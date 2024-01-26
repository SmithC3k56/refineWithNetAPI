using System.ComponentModel.DataAnnotations;

namespace RefineAPI.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public string? description { get; set; }
        public string? price { get; set; }
        public string? material { get; set; }
        public required Category category { get; set; }
    }
}
