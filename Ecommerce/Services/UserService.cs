using Ecommerce.Interface;
using EcommerceData.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace Ecommerce.Services
{
    public class UserService : IUsers
    {
        private readonly IUserRepo _userRepo;
       
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;           
        }
       

        public async Task<List<User>> GetUsers()
        {
            var users = await _userRepo.GetUser();

            if (users == null)
            {
                return null;
            }

            return users;
        }
        public async Task<User> GetUserByEmailPasswordService(LoginViewModel viewModel)
        {

            var users = await _userRepo.GetUser();
            var user = users.FirstOrDefault(s => s.Email == viewModel.Email && s.Password == viewModel.Password);
            if (user == null)
            {
                return null;
            }
            return user;    
        }
       
    }
}
