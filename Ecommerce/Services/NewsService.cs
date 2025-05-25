using Ecommerce.Interface;
using Ecommerce.Models;
using EcommerceData.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class NewsService : INews
    {
       private readonly INewsRepo _newsRepo;
        public NewsService(INewsRepo newsRepo)
        {
            _newsRepo = newsRepo;           
        }
        public async Task<List<News>> GetNews()
        {
            try
            {
               var news = await _newsRepo.GetNews();                
               return news;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
