using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BluedIT.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupCategory { get; set; }
        public string GroupDescription { get; set; }
        public Post Post { get; set; }
        public ICollection<GroupCategory> GroupCategories { get; set; }

    }
}
