using Microsoft.AspNetCore.Mvc;

namespace Activity2_BasicRouting.Controllers
{
    public class OperationsController : Controller
    {
        public IActionResult Index()
        {
            return Content("No input.");
        }
        public IActionResult Add(int num1, int num2)
        {
            int result = (num1+ num2);
            return Content($"Sum = {result}");
        }

        public IActionResult Subtract(int num1, int num2)
        {
            int result = (num1 - num2);
            return Content($"Difference is {result}");
        }

        public IActionResult Multiply(int num1, int num2)
        {
            int result = (num1 * num2);
            return Content($"Product is {result}");
        }

        public IActionResult Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Division by zero.");
            }
            else
            {
                int result = (num1/num1);
                return Content($"Quotient is {result}");
            }
        }
    }
}
