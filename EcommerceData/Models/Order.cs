using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; } 
        public Product Product { get; set; }  
        public User User { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }  

    }
}
