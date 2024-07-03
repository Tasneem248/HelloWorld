using Microsoft.AspNetCore.Mvc;
using HelloWorldApi.Models;
using HelloWorld;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost("is-prime")]
        public ActionResult<string> CheckIfPrime([FromBody] PrimeCheckRequest request)
        {
            if (IsPrime(request.Number))
            {
                return $"{request.Number} is a prime number.";
            }
            else
            {
                return $"{request.Number} is not a prime number.";
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}