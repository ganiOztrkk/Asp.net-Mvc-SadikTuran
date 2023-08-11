using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Status { get; set; }
        public bool Homepage { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}