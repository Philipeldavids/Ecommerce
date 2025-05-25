using Ecommerce.Interface;
using Ecommerce.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticate _authenticate;
        public AuthenticationController(IAuthenticate authenticate)
        {
            _authenticate = authenticate;
        }

        [HttpGet]
        public IActionResult GetLogin()
        {            
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> GetLogin(LoginViewModel viewModel, UserProductViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (await _authenticate.LoginAsync(viewModel))
                {
                    model.IsLogin = true;
                    return RedirectToAction("Index", "Home", model);
                }
            }
            return View(viewModel);
        }
        public IActionResult LoadSignUp()
        {
            return View();
        }
        
    }
}
