namespace BluedIT.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostedOn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
    }
}
