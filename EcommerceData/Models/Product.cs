using EcommerceData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class Product 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Color Color { get; set; }
        public string Price { get; set; }
        public Category Category { get; set; }  
        public Brands Brand { get; set; }
        public int Rating { get; set; }
        public Size Size { get; set; }
        public int NoOfPurchase { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int PercentOff { get; set; }
        public bool IsFeatured { get; set; }
        public bool Availability { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
