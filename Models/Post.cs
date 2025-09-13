using System.ComponentModel.DataAnnotations;

namespace Blog_Site.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public string Date { get; set; }

        public string Images { get; set; }

        public string slug { get; set; } 
    }
}
