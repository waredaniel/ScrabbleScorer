using System;
using System.Collections.Generic;

namespace ScrabbleScorer
{
  public class ScrabbleScorer
  {
    // public string userword = "abc";
    public static int Word(string userWord)
    {
      int scrabbleScore = 0;
      char[] scrabbleWord = userWord.ToLower().ToCharArray();
      for (int i=0; i<scrabbleWord.Length; i++){

        if (scrabbleWord[i] == 'a' || scrabbleWord[i] == 'e' || scrabbleWord[i] == 'i' || scrabbleWord[i] == 'o' || scrabbleWord[i] == 'u' || scrabbleWord[i] == 'l' || scrabbleWord[i] == 'n' || scrabbleWord[i] == 'r' || scrabbleWord[i] == 's' || scrabbleWord[i] == 't') 
        {
          scrabbleScore += 1;
        }
        else if (scrabbleWord[i] == 'd' || scrabbleWord[i] == 'g')
        {
          scrabbleScore += 2;
        }
        else if (scrabbleWord[i] == 'b' || scrabbleWord[i] == 'c' || scrabbleWord[i] == 'm' || scrabbleWord[i] == 'p')
        {
          scrabbleScore += 3;
        }
        else if (scrabbleWord[i] == 'f' || scrabbleWord[i] == 'h' || scrabbleWord[i] == 'v' || scrabbleWord[i] == 'w' || scrabbleWord[i] == 'y')
        {
          scrabbleScore += 4;
        }
        else if (scrabbleWord[i] == 'k')
        {
          scrabbleScore += 5;
        }
        else if (scrabbleWord[i] == 'j' || scrabbleWord[i] == 'x')
        {
          scrabbleScore += 8;
        }
        else if (scrabbleWord[i] == 'q' || scrabbleWord[i] == 'z')
        {
          scrabbleScore += 10;
        }
        else {
          scrabbleScore += 0;
        } 
      } return scrabbleScore;
    }
  }
}