using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EcommerceData.Models
{
    public class News
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}