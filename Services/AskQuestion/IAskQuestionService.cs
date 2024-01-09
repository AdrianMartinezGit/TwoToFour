using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services.AskQuestion;

public interface IAskQuestionService {
    string AskFirstQuestion(string firstQuestion);
    string AskSecondQuestion(string secondQuestion);
}