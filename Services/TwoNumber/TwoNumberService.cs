namespace TwoToFour.Services.TwoNumber;

public class TwoNumberService : ITwoNumberService
{
    public string AddTwoNumbers(string firstNumber, string secondNumber)
    {
        int numberOne = 0;
        int numberTwo = 0;
        int totalSum = 0;
        bool numberTrue = int.TryParse(firstNumber, out numberOne);

        if (numberTrue == false) {
            return "Please enter a real number on {firstNumber}";
        }

        numberTrue = int.TryParse(secondNumber, out numberTwo);

        if (numberTrue == false) {
            return "Please enter a real number on {secondNumber}";
        }

        totalSum = numberOne + numberTwo;

        return "The total sum of the numbers is " + totalSum.ToString();
    }
}