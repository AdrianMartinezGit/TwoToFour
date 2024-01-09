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

    [HttpPost]
    [Route("AskFirstQuestion/{firstQuestion}")]
    public string AskFirstQuestion(string firstQuestion)
    {
        return _askQuestionService.AskFirstQuestion(firstQuestion);
    }

    [HttpPost]
    [Route("AskSecondQuestion/{secondQuestion}")]
    public string AskSecondQuestion(string secondQuestion)
    {
        return _askQuestionService.AskSecondQuestion(secondQuestion);
    }
}
