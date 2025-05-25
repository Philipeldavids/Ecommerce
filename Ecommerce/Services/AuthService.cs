using Ecommerce.Interface;
using Ecommerce.Models.ViewModel;
using EcommerceData.DataBase;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class AuthService : IAuthenticate
    {
        private readonly IUserRepo _userRepo;

        public AuthService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<bool> LoginAsync(LoginViewModel model)
        {
            var users = await _userRepo.GetUser();
            var user = users.FirstOrDefault(s => s.Email == model.Email && s.Password == model.Password);

            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
