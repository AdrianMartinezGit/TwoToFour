namespace TwoToFour.Services.AskQuestion;

public interface IAskQuestionService {
    string AskFirstQuestion(string firstQuestion);
    string AskSecondQuestion(string secondQuestion);
}