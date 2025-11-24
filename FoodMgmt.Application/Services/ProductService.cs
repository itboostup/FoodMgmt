using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMgmt.Application.Interfaces;
using FoodMgmt.Domain.Entity;
using FoodMgmt.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FoodMgmt.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDBContext _appDBContext;
        public ProductService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public List<Product> GetProduct()
        {
            var products = _appDBContext.Product.Include(p=>p.Brand).ToList();
            // Projection to DTO (null-safe)
           
            
            
            return products;
        }
    }
}
