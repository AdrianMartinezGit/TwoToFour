using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services.GreaterOrLess;

namespace TwoToFour.Controllers;

[ApiController]
[Route("[controller]")]

public class GreaterOrLessController : ControllerBase
{
    private readonly IGreaterOrLessService _greaterOrLessService;

    public GreaterOrLessController(IGreaterOrLessService greaterOrLessService)
    {
        _greaterOrLessService = greaterOrLessService;
    }
    
    [HttpGet]
    [Route("GreaterOrLessThan/{firstNumber}/{secondNumber}")]
    public string GreaterOrLessThan(string firstNumber, string secondNumber)
    {
        return _greaterOrLessService.GreaterOrLessThan(firstNumber, secondNumber);
    }
}
