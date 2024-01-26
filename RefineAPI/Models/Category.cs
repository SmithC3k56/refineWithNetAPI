using System.ComponentModel.DataAnnotations;

namespace RefineAPI.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public required string title { get; set; }
    }
}
