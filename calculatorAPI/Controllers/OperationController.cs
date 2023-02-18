using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using calculatorAPI.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace calculatorAPI.Controllers
{
        [Route("api/[controller]/[action]")]
        [ApiController]
        public class OperationController : ControllerBase
        {

        [HttpGet("{a}/{b}")]
        public IActionResult Sum(double a, double b)
        {
            OperationService opService = new OperationService(new Addition());
            double result = opService.GenerateOperation(a,b);

            return Ok(new { result });
        }

        [HttpGet("{a}/{b}")]
        public IActionResult Subtract(double a, double b)
        {
            OperationService opService = new OperationService(new Subtraction());
            double result = opService.GenerateOperation(a, b);

            return Ok(new { result });
        }

        [HttpGet("{a}/{b}")]
        public IActionResult Multiply(double a, double b)
        {
            OperationService opService = new OperationService(new Multiplication());
            double result = opService.GenerateOperation(a, b);

            return Ok(new { result });
        }

        [HttpGet("{a}/{b}")]
        public IActionResult Divide(double a, double b)
        {
            OperationService opService = new OperationService(new Division());
            double result = opService.GenerateOperation(a, b);

            return Ok(new { result });
        }

    }
}






