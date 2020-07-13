using System;
using System.Collections.Generic;

namespace Arcade{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number");
      string userInput = Console.ReadLine();
      int firstNumber = int.Parse(userInput);
      Console.WriteLine("Here's your game of ping-pong!");
      for (int number = 1; number <= firstNumber; number++)
    {
      if (number % 3 == 0 && number % 5 == 0) 
      {
        Console.WriteLine("ping-pong");
      }
      else if (number % 3 == 0)
      {
        Console.WriteLine("ping");
      } 
      else if (number % 5 == 0) 
      {
        Console.WriteLine("pong");
      }
      else 
      { 
        Console.WriteLine(number);
      }
    }
    Console.WriteLine("Do you want to play again? ['Y' for yes, 'Enter' for no]");
    string playAgain = Console.ReadLine();
    if (playAgain == "y" || playAgain == "Y")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Goodbye");
    }
  }
}
}


