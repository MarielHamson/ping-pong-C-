using System;
using System.Collections.Generic;
using Arcade.Game;

namespace Arcade{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number");
      string userInput = Console.Readline();
      int firstNumber = int.Parse(userInput);
      Console.WriteLine("Here's your game of ping-pong!");
      for (int number = firstNumber; number <= firstNumber; number++)
    {
      if (number % 3 == 0 && number % 5 == 0) 
      {
        Console.WriteLine("ping-pong")
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
  }
}


