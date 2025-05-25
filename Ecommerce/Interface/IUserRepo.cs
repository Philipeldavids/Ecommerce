using Ecommerce.Models.ViewModel;
using EcommerceData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IUserRepo
    {
        Task<List<User>> GetUser();       
        bool AddUser(User user);
    }
}
