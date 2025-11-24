
using FoodMgmt.Domain.Entity;

namespace FoodMgmt.Application.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        int Create(Brand brand);
        int Update(Brand brandDto);
        Brand GetById(int brandId);
    }
}
