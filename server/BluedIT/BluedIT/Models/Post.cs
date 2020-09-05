using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BluedIT.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostedOn { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
        public Group Group { get; set; }
        public User User { get; set; }
        
    }
}
