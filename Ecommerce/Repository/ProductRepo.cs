using Ecommerce.Interface;
using EcommerceData.DataBase;
using EcommerceData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class ProductRepo : IProductRepo
    {
        public readonly ApplicationDbContext _dbContext;

        public ProductRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> GetProduct()
        {
            //Eager Loading
            var products = await _dbContext.Products                                            
                        .Include(s => s.Category).ToListAsync();


            return products;
        }
    }
}
