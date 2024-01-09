using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services.TwoNumber;

namespace TwoToFour.Controllers;

[ApiController]
[Route("[controller]")]

public class TwoNumberController : ControllerBase
{
    private readonly ITwoNumberService _twoNumberService;

    public TwoNumberController(ITwoNumberService twoNumberService)
    {
        _twoNumberService = twoNumberService;
    }

    [HttpPost]
    [Route("AddTwoNumbers/{firstNumber}/{secondNumber}")]
    public string AddTwoNumbers(string firstNumber, string secondNumber)
    {
        return _twoNumberService.AddTwoNumbers(firstNumber, secondNumber);
    }
}