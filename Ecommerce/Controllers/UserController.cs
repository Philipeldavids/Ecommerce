using Ecommerce.Interface;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using EcommerceData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class UserController : BaseController
    {
        
        private readonly IUserRepo _userRepo;
       
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Register(UserViewModel viewmodel)
        {
            var newUser = new User
            {
                FirstName = viewmodel.FirstName,
                LastName = viewmodel.LastName,
                Email = viewmodel.Email,
                Password = viewmodel.Password,
                PhoneNumber = viewmodel.PhoneNumber,
                Gender = viewmodel.Gender = true ? "Male" : "Female",
                DateOfBirth = viewmodel.DateofBirth,
            };
            var userAdded = _userRepo.AddUser(newUser);

            if (userAdded)
            {
                return RedirectToAction("GetLogin", "Authentication");
            }

            return View();
        }
    }
}
