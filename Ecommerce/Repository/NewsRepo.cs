using Ecommerce.Interface;
using EcommerceData.DataBase;
using EcommerceData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class NewsRepo : INewsRepo
    {
        public readonly ApplicationDbContext _dbContext;

        public NewsRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<News>> GetNews()
        {           
            var news = await _dbContext.News.ToListAsync();                 
       
            return news;
        }
    }
}
