using System;

/*
 * create a function that takes a string of lowercase characters and returns that string reverse and capitalize
 */
namespace ex18
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "abc", s2 = "hellothere", s3 = "input";

      PrintResults(s1);
      PrintResults(s2);
      PrintResults(s3);
    }

    static void PrintResults(string s1)
    {
      Console.WriteLine($"{s1} -> {ReverseCapitalize(s1)}");
    }

    static string ReverseCapitalize(string s1)
    {
      if (s1 == null) return "";

      char[] results = new char[s1.Length];

      for (int i = s1.Length - 1, j = 0; i >= 0; i--, j++)
        results[j] = char.ToUpper(s1[i]);

      return new String(results);
    }
  }
}
