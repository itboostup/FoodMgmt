using FoodMgmt.Application.Interfaces;
using FoodMgmt.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodMgmt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAllBrands")]
        public ActionResult GetAllBrands()
        {
            return Ok(_brandService.GetBrands());
        }

        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            return Ok(_brandService.Create(brand));
        }

        [HttpPut]
        public ActionResult Update(Brand brand)
        {
            return Ok(_brandService.Update(brand));
        }
        [HttpGet("GetById/{brandId}")]
        public ActionResult GetById(int brandId)
        {
            return Ok(_brandService.GetById(brandId));
        }
    }
}
