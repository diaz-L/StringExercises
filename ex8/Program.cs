using System;

/*
 * Create a function that takes two string and returns true if the first string ends with second string
 */
namespace ex8
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "abc", s2 = "samurai", s3 = "feminine";

      Console.WriteLine(EndsWith(s1, "bc"));
      Console.WriteLine(EndsWith(s1, "d"));
      Console.WriteLine(EndsWith(s2, "zi"));
      Console.WriteLine(EndsWith(s3, "nine"));
    }

    static bool EndsWith(string s1, string s2)
    {
      return s1.EndsWith(s2);
    }
  }
}
