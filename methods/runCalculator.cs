using System;
using Calculator.calculations;

namespace Calculator.runStuff
{
  public class theCalculator
  {
    theCalculations newCalculations = new theCalculations();
    string works = "runCalculator works!";
    public void runCalculator()
    {
      Console.WriteLine(works);
      newCalculations.runAdd();
    }
  }
}