namespace TwoToFour.Services.GreaterOrLess;

public class GreaterOrLessService : IGreaterOrLessService
{
    public string GreaterOrLessThan(string firstNumber, string secondNumber)
    {
        int numberOne = 0;
        int numberTwo = 0;
        bool numberTrue = int.TryParse(firstNumber, out numberOne);

        if (numberTrue == false) {
            return "Please enter a real number on {firstNumber}";
        }

        numberTrue = int.TryParse(secondNumber, out numberTwo);

        if (numberTrue == false) {
            return "Please enter a real number on {secondNumber}";
        }

        if (numberOne > numberTwo) {
            return $"{numberOne} is greater than {numberTwo}, and {numberTwo} is less than {numberOne}";
        } else if (numberOne < numberTwo) {
            return $"{numberOne} is less than {numberTwo}, and {numberTwo} is greater than {numberOne}";
        } else if (numberOne == numberTwo) {
            return $"{numberOne} is equal to {numberTwo}, and {numberTwo} is equal to {numberOne}";
        } else {
            return "Null";
        }
    }
}