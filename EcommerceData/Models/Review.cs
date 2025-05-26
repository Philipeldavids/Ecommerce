using EcommerceData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }       
        public Product Product { get; set; }                                                 
        public User User { get; set; }
        public string Details { get; set; }
        public Ratings Rating { get; set; }
    }
}
