using Ecommerce.Models.ViewModel;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface IAuthenticate
    {
        Task<bool> LoginAsync(LoginViewModel model);
    }
}
