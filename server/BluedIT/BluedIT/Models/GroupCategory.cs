using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluedIT.Models
{
    public class GroupCategory
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
