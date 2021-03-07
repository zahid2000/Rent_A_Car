using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarBrandsController : ControllerBase
    {
        ICarBrandService _carBrandService;

        public CarBrandsController(ICarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        [HttpPost("add")]
        public IActionResult Add(CarBrand carBrand)
        {
            var result = _carBrandService.Add(carBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarBrand carBrand)
        {
            var result = _carBrandService.Delete(carBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarBrand carBrand)
        {
            var result = _carBrandService.Update(carBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carBrandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbrandid")]
        public IActionResult GetBrandId(int id)
        {
            var result = _carBrandService.GetBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
    }
}
