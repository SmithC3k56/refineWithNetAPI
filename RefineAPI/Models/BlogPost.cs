using System.ComponentModel.DataAnnotations;

namespace RefineAPI.Models
{
    public class BlogPost
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public Category category { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; } =   DateTime.Now;
    }

}
