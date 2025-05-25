using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduct _product;
        private readonly IAuthenticate _authenticate;
        private readonly INews _news;

        public HomeController(ILogger<HomeController> logger, IProduct product, IAuthenticate authenticate, INews news)
        {
            _logger = logger;
            _product = product;
            _authenticate = authenticate;
            _news = news;

        }

        public async Task<IActionResult> Index(UserProductViewModel userProductViewModel)
        {                    

            userProductViewModel.ProductView = await _product.GetProduct();
            userProductViewModel.News = await _news.GetNews();
            if (userProductViewModel.User != null)
            {
                userProductViewModel.IsLogin = true;
            }
            
            return View(userProductViewModel);
        }
        public async Task<IActionResult> LoadMore(UserProductViewModel model, LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authenticate.LoginAsync(viewModel))
                {
                    model.IsLogin = true;
                    return RedirectToAction("ProductInfo", "Products", model);
                }
            }

            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
