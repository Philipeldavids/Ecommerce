using EcommerceData.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IUsers
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserByEmailPasswordService(LoginViewModel loginViewModel);
        //Task<bool> AddUser(User user);
    }
}
