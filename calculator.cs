using System; //give us access to the Console object and its methods
using Calculator.runStuff;


class Program 
{
  static void Main() //automatically run, an entry point method
  {
    theCalculator newCalculator = new theCalculator();
    Console.WriteLine("Main!");
    newCalculator.runCalculator();
    
  }
}