﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BluedIT.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostedOn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Comments { get; set; }
        public string Tag { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
    }
}
