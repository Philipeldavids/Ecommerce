using Ecommerce.Interface;
using Ecommerce.Models.ViewModel;
using EcommerceData.DataBase;
using EcommerceData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class UserRepo : IUserRepo
    {
        public readonly ApplicationDbContext _dbContext;

        public UserRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<User>> GetUser()
        {
            //Eager Loading
            var users = await _dbContext.Users
                        .Include(s => s.Orders)
                        .Include(s => s.Reviews).ToListAsync();

            return users;
        }
         
        public bool AddUser(User user)
        {
            try
            {
                _dbContext.Add(user);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
