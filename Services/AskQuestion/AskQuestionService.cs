namespace TwoToFour.Services.AskQuestion;

public class AskQuestionService : IAskQuestionService
{
    //string chosenName = "Aaron";
    //string chosenTime = "8:00 in the morning.";

    public string AskFirstQuestion(string firstQuestion)
    {
        // if (firstQuestion == "what is your name?") {
        //     return $"My name is {chosenName}";
        // } else {
        //     return "I'm sorry, I don't understand that. Try Again.";
        // }
        return $"What is your name?\nMy Name is {firstQuestion}";
    }

    public string AskSecondQuestion(string secondQuestion)
    {
        // if (secondQuestion == "what time did you wake up?") {
        //     return $"I woke up at around {chosenTime}";
        // } else {
        //     return "I'm sorry, I don't understand that. Try Again.";
        // }

        return $"What time did you wake up?\nI woke up at around {secondQuestion}";
    }
}