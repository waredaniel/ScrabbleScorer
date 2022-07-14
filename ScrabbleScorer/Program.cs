using System;
using ScrabbleScorer;

namespace ScrabbleScorer
{
  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("Enter your word");
    string userWord = Console.ReadLine();

    Console.WriteLine("Your score is " + ScrabbleScorer.Word(userWord));
    }
  }
}