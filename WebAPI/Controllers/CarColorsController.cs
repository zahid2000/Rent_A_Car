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
    public class CarColorsController : ControllerBase
    {
        ICarColorService _carColorService;

        public CarColorsController(ICarColorService carColorService)
        {
            _carColorService = carColorService;
        }

        [HttpPost("add")]
        public IActionResult Add(CarColor carColor)
        {
            var result = _carColorService.Add(carColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
        [HttpPut]
        public IActionResult Update(CarColor carColor)
        {
            var result = _carColorService.Update(carColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(CarColor carColor)
        {
            var result = _carColorService.Delete(carColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //ICarColorService _carColorService=new CarColorManager(new EFCarColorDal());
            var result = _carColorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcolorid")]
        public IActionResult GetColorId(int id)
        {
            var result = _carColorService.GetColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
