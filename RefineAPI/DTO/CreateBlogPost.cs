using RefineAPI.Models;

namespace RefineAPI.DTO
{
    public class CreateBlogPost
    {
        public required string title { get; set; }
        public string content { get; set; } = string.Empty;
        public required int categoryId { get; set; }
        public string? status { get; set; }
    }
}
