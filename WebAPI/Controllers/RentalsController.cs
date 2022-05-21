using Business.Abstract;
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



    }
}
