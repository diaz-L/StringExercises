using System;

/*
 * Write a function that given a string returns the number of vowels contained within it
 */
namespace ex13
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Celebration", s2 = "Palm", s3 = "Prediction";

      PrintVowelCount(s1);
      PrintVowelCount(s2);
      PrintVowelCount(s3);
    }

    static void PrintVowelCount(string s1)
    {
      Console.WriteLine($"string: {s1}, count: {CountVowels(s1)}");
    }

    static int CountVowels(string s1)
    {
      int count = 0;

      foreach (var c in s1)
        switch (c)
        {
          case 'a':
          case 'A':
          case 'e':
          case 'E':
          case 'i':
          case 'I':
          case 'o':
          case 'O':
          case 'u':
          case 'U':
            count++;
            break;
        }

      return count;
    }
  }
}
