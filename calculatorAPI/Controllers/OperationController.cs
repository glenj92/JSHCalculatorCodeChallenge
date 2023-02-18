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



        //private readonly IOperation _operation;

        //public OperationController(IOperation operation)
        //{
        //    _operation = operation;
        //}

        //[HttpGet]
        //public async Task<IActionResult> Sum(double a, double b)
        //{
        //    var result = await _operation.OperSum(a, b);

        //    int result = await CalculatorOperation.PerformOperation(a, b, CalculatorOperation.OperationType.Add);
        //    return Ok(new { Result = result });
        //}


        //[HttpGet("{num1}/{num2}/add")]
        //public async Task<ActionResult<int>> Add(int num1, int num2)
        //{
        //    int result = await Task.Run(() => num1 + num2);
        //    return Ok(new { Result = result });
        //}

        //[HttpGet("{num1}/{num2}/subtract")]
        //public async Task<ActionResult<int>> Subtract(int num1, int num2)
        //{
        //    int result = await Task.Run(() => num1 - num2);
        //    return Ok(new { Result = result });
        //}

        //[HttpGet("{num1}/{num2}/multiply")]
        //public async Task<ActionResult<int>> Multiply(int num1, int num2)
        //{
        //    int result = await Task.Run(() => num1 * num2);
        //    return Ok(new { Result = result });
        //}

        //[HttpGet("{num1}/{num2}/divide")]
        //public async Task<ActionResult<int>> Divide(int num1, int num2)
        //{
        //    if (num2 == 0)
        //    {
        //        return BadRequest("Cannot divide by zero");
        //    }

        //    int result = await Task.Run(() => num1 / num2);
        //    return Ok(new { Result = result });
        //}








        //    [HttpGet("add/{a}/{b}")]
        //    public async Task<IActionResult> Sum(double a, double b)
        //    {
        //        double result = await CalculatorOperation.PerformOperation(a, b, CalculatorOperation.OperationType.Sum);
        //        return Ok(new { Result = result });
        //    }

        //    [HttpGet("subtract/{a}/{b}")]
        //    public async Task<IActionResult> Subtract(double a, double b)
        //    {
        //        double result = await CalculatorOperation.PerformOperation(a, b, CalculatorOperation.OperationType.Subtract);
        //        return Ok(new { Result = result });
        //    }

        //    [HttpGet("multiply/{a}/{b}")]
        //    public async Task<IActionResult> Multiply(double a, double b)
        //    {
        //        double result = await CalculatorOperation.PerformOperation(a, b, CalculatorOperation.OperationType.Multiply);
        //        return Ok(new { Result = result });
        //    }

        //    [HttpGet("divide/{a}/{b}")]
        //    public async Task<IActionResult> Divide(double a, double b)
        //    {
        //        double result = await CalculatorOperation.PerformOperation(a, b, CalculatorOperation.OperationType.Divide);
        //        return Ok(new { Result = result });
        //    }
        //}

        //public static class CalculatorOperation
        //{
        //    public enum OperationType
        //    {
        //        Sum,
        //        Subtract,
        //        Multiply,
        //        Divide
        //    }

        //    public static async Task<double> PerformOperation(double a, double b, OperationType operationType)
        //    {
        //        return await Task.Run(() =>
        //        {
        //            switch (operationType)
        //            {
        //                case OperationType.Sum:
        //                    return a + b;
        //                case OperationType.Subtract:
        //                    return a - b;
        //                case OperationType.Multiply:
        //                    return a * b;
        //                case OperationType.Divide:
        //                    if (b == 0)
        //                    {
        //                        throw new DivideByZeroException();
        //                    }
        //                    return a / b;
        //                default:
        //                    throw new ArgumentOutOfRangeException(nameof(operationType), "Invalid operation type.");
        //            }
        //        });
        //    }





    }
}






