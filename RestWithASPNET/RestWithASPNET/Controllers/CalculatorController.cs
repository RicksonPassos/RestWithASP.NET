using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{

    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult Subtraction(string firstNumber, string secondNumber)
    {
        if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
           var sub = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
            return Ok(sub.ToString());
        }

        return BadRequest("Invalid Input");
    }

    [HttpGet("mult/{firstNumber}/{secondNumber}")]
    public IActionResult Multiplication(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mult = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
            return Ok(mult.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("div/{firstNumber}/{secondNumber}")]
    public IActionResult Division(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var div = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
            return Ok(div.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("mean/{firstNumber}/{secondNumber}")]
    public IActionResult Mean(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var mean = (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)) / 2;
            return Ok(mean.ToString());
        }
        return BadRequest("Invalid Input");
    }

    [HttpGet("squareRoot/{number}")]
    public IActionResult SquareRoot(string number)
    {
        if (IsNumeric(number))
        {
            var squareRoot = Math.Sqrt((double)Convert.ToDecimal(number));
            return Ok(squareRoot.ToString());
        }
        return BadRequest("Invalid Input");
    }

    private static bool IsNumeric(string strNumber)
    {
        return double.TryParse(strNumber, System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out _);
        
    }

}
