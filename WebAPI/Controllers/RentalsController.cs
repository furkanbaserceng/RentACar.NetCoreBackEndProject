﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getrentaldetails")]
        public IActionResult GetRentalDetails()
        {

            var result = _rentalService.GetRentalDetail();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {

            var result = _rentalService.Add(rental);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Rental rental)
        {

            var result = _rentalService.Update(rental);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {

            var result = _rentalService.Delete(rental);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
