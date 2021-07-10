using System;
using Calculator.calculations;

namespace Calculator.runStuff
{
  public class theCalculator
  {
    theCalculations newCalculations = new theCalculations();
    public void runCalculator()
    {
      Console.WriteLine("welcome to the calculator");        
      Console.WriteLine("enter your first number");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter your second number");
      int num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("what would you like to do? + - / * ");
      string val = (Console.ReadLine());
      if (val == "+")
      {
        newCalculations.runAdd(num1, num2);
      } 
      else if (val == "-")
      {
        newCalculations.runSubtract(num1, num2);
      } 
      else if (val == "/")
      {
        newCalculations.runDivide(num1, num2);
      }
      else if (val == "*")
      {
        newCalculations.runMultiply(num1, num2);
      }
      else 
      {
        Console.WriteLine("please enter a real modifier");
      }      

    }
  }
}