using System.ComponentModel.DataAnnotations;

namespace BluedIT.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string PostedOn { get; set; }
        
    }
}
