using EcommerceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Models.ViewModel
{
    public class UserProductViewModel
    {
        public User User { get; set; }
        public List<Product> ProductView { get; set; }
        public List<News> News { get; set; }
        public Product Product { get; set; }
        public bool IsLogin { get; set; }
        public int ProductPerPage { get; set; }
        public int Currentpage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(ProductView.Count() / (double)ProductPerPage));
        }

        public IEnumerable<Product> PaginatedPage()
        {
            int start = (Currentpage - 1) * ProductPerPage;
            return ProductView.OrderBy(x => x.Id).Skip(start).Take(ProductPerPage);
        }

    }
}
