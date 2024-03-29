using Microsoft.AspNetCore.Mvc;
using TwoToFour.Services.AskQuestion;

namespace TwoToFour.Controllers;

[ApiController]
[Route("[controller]")]

public class AskQuestionController : ControllerBase
{
    private readonly IAskQuestionService _askQuestionService;

    public AskQuestionController(IAskQuestionService askQuestionService)
    {
        _askQuestionService = askQuestionService;
    }

    [HttpGet]
    [Route("AskFirstQuestion/{firstQuestion}")]
    public string AskFirstQuestion(string firstQuestion)
    {
        return _askQuestionService.AskFirstQuestion(firstQuestion);
    }

    [HttpGet]
    [Route("AskSecondQuestion/{secondQuestion}")]
    public string AskSecondQuestion(string secondQuestion)
    {
        return _askQuestionService.AskSecondQuestion(secondQuestion);
    }
}
