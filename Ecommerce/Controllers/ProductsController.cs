using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProduct _product;
      
        public ProductsController(IProduct product)
        {
            _product = product;
        }
        public async Task<IActionResult> ProductLists(int page = 1)
        {
            var products = await _product.GetProduct();
            var productView = new UserProductViewModel()
            {
                ProductView = products,
                ProductPerPage = 9,
                Currentpage = page,
                IsLogin = true  
            };
            return View(productView);
        }
        public async Task<IActionResult> ProductInfo(int Id)
        {
            
            var products = await _product.GetProduct();
            var product = products.Find(x=> x.Id == Id);    

            var productsView = new UserProductViewModel()
            {
                Product = product
            };
            return View(productsView);
        }
    }
}
