using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMgmt.Application.Interfaces;
using FoodMgmt.Domain.Entity;
using FoodMgmt.Infrastructure.Context;

namespace FoodMgmt.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDBContext _appDBContext;
        public BrandService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public List<Brand> GetBrands()
        {
            var brands = _appDBContext.Brand.ToList();
            return brands;
        }

        public int Create(Brand brand)
        {
            _appDBContext.Add(brand);
            brand.CreatedBy = 1;
            brand.CreatedOn = DateTime.Now;
            brand.ModifiedOn = DateTime.Now;
            brand.ModifiedBy = 1;
            var result = _appDBContext.SaveChanges();
            return result;
        }

        public int Update(Brand brandDto)
        {
            var brand = _appDBContext.Brand.Find(brandDto.BrandId);
            if (brand == null)
                return 0;

            brand.BrandName = brandDto.BrandName;
            brand.DisplayName = brandDto.DisplayName;
            brand.Description = brandDto.Description;
            brand.IsActive = brandDto.IsActive;
            brand.ModifiedOn = DateTime.Now;
            brand.ModifiedBy = 1;

            _appDBContext.Update(brand);
            var result = _appDBContext.SaveChanges();
            return result;
        }
        public Brand GetById(int brandId) 
        {
            var brand = _appDBContext.Brand.Find(brandId);
            return brand;
        }
    }
}
