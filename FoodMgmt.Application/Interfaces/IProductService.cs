using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMgmt.Domain.Entity;

namespace FoodMgmt.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProduct();
    }
}
