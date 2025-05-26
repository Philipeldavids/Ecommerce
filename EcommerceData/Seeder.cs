using EcommerceData.DataBase;
using EcommerceData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData
{
    public class Seeder
    {
        public static async Task SeedData(ApplicationDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            await dbContext.Database.EnsureCreatedAsync();


            if (!dbContext.Users.Any())
            {

                var pth = File.ReadAllText(FilePath(baseDir, "Json/Users.json"));

                var users = JsonConvert.DeserializeObject<List<User>>(pth);
                await dbContext.Users.AddRangeAsync(users);
            }

            if (!dbContext.Products.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "Json/Product.json"));

                var products = JsonConvert.DeserializeObject<List<Product>>(path);
                await dbContext.Products.AddRangeAsync(products);
            }
            if (!dbContext.News.Any())
            {
                var path = File.ReadAllText(FilePath(baseDir, "Json/News.json"));

                var news = JsonConvert.DeserializeObject<List<News>>(path);
                await dbContext.News.AddRangeAsync(news);
            }

            await dbContext.SaveChangesAsync();
        }
        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }
}
