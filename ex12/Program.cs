using System;
using System.Threading;

/*
 * Create a function that takes a character and string and returns the number of times the 
 * character is found in the string.
 */
namespace ex12
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "edabit", s2 = "Chamber of secrets", s3 = "big fat bubble";
      char c1 = 'a', c2 = 'c', c3 = 'b';

      Console.WriteLine($"{s1} >>{c1}<< count: {CharCount(c1, s1)}");
      Console.WriteLine($"{s2} >>{c2}<< count: {CharCount(c2, s2)}");
      Console.WriteLine($"{s3} >>{c3}<< count: {CharCount(c3, s3)}");
    }

    static int CharCount(char c, string s1)
    {
      int count = 0;
      foreach (var letter in s1)
        if (c == letter)
          count++;

      return count;
    }
  }
}
