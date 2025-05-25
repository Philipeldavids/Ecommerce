using EcommerceData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface INewsRepo
    {
        Task<List<News>> GetNews();
    }
}
