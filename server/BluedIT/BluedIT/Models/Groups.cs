using System.ComponentModel.DataAnnotations;

namespace BluedIT.Models
{
    public class Groups
    {
        [Key]
        public string GroupName { get; set; }
        public string GroupCategory { get; set; }
        public string GroupDescription { get; set; }
    }
}
