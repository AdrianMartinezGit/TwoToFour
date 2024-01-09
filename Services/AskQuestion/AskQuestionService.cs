using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services.AskQuestion;

public class AskQuestionService : IAskQuestionService
{
    public string AskFirstQuestion(string firstQuestion)
    {
        if (firstQuestion == "what is your name?") {
            return "My name is Aaron";
        } else {
            return "I'm sorry, I don't understand that. Try Again.";
        }
    }

    public string AskSecondQuestion(string secondQuestion)
    {
        if (secondQuestion == "what time did you wake up?") {
            return "I woke up at around 8:00 in the morning.";
        } else {
            return "I'm sorry, I don't understand that. Try Again.";
        }
    }
}