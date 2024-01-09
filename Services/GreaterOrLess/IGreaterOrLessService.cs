using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour.Services.GreaterOrLess;

public interface IGreaterOrLessService {
    string GreaterOrLessThan(string firstNumber, string secondNumber);
}