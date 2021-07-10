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
      Console.WriteLine("welcome to the calculator");        
      Console.WriteLine("enter your first number");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter your second number");
      int num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("what would you like to do? + - / * ");
      string val = (Console.ReadLine());
      newCalculations.runAdd();
      Console.WriteLine(num1);
      Console.WriteLine(num2);
      Console.WriteLine(val);
    }
  }
}