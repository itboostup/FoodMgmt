using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Domain.Entity
{
    public class Product  : BaseAuditEntity
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;

        public Brand Brand { get; set; }
    }
}
