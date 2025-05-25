using Ecommerce.Interface;
using Ecommerce.Models;
using EcommerceData.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService : IProduct
    {
        private readonly IProductRepo _productRepo;
        
        public ProductService(IProductRepo productRepo)
        {
            
            _productRepo = productRepo;            
        }
        public async Task<List<Product>> GetProduct()
        {
            try
            {
                var products = await _productRepo.GetProduct();

                return products;
            }

            catch (Exception)
            {
                throw;
            }
        }
        /*public async Task<Product> GetProductsById(int id)
        {
            var dbproducts = await _handler.SelectProductById("dbo.spGetProductsById", id);

            try
            {
                Product product = null;
                while (dbproducts.Read())
                {
                    product = new Product()
                    {
                        Id = (int)dbproducts["Id"],
                        Name = dbproducts["Name"].ToString(),
                        CategoryId = (int)dbproducts["CategoryId"],
                        Brand = dbproducts["Brand"].ToString(),
                        Description = dbproducts["Description"].ToString(),
                        Color = dbproducts["Color"].ToString(),
                        Size = dbproducts["Size"].ToString(),
                        ImageUrl = dbproducts["ImageUrl"].ToString(),
                        IsFeatured = (bool)dbproducts["Featured"],
                        PercentOff = (int)dbproducts["PercentOff"],
                        Price = (decimal)dbproducts["UnitPrice"],
                        DiscountedPrice = (decimal)dbproducts["DiscountedPrice"],
                        Rating = (int)dbproducts["Rating"],
                        Quantity = (int)dbproducts["Quantity"],
                        Availability = (bool)dbproducts["Availability"],
                    };

                }
                return product;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (dbproducts != null)
                {
                    dbproducts.Close();
                }

                if (_connectionHandler.ConnectObj.State == ConnectionState.Open)
                {
                    _connectionHandler.ConnectObj.Close();
                }

            }
        }*/

    }
}
