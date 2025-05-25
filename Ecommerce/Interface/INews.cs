using Ecommerce.Models;
using EcommerceData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Interface
{
    public interface INews
    {
        Task<List<News>> GetNews();
    }
}
