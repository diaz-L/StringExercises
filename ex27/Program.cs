using System;
using System.Collections.Generic;

/*
 * create a function that takes a string and returns the number of alphanumeric characters that occur more
 * than once. String is case-sensitive.
 */
namespace ex27
{
  static class Program
  {
    static void Main(string[] args)
    {
      string s1 = "abcde", s2 = "aabbcde", s3 = "Indivisibilities", s4 = "Aa";

      PrintDuplicateCount(s1);
      PrintDuplicateCount(s2);
      PrintDuplicateCount(s3);
      PrintDuplicateCount(s4);
    }

    static void PrintDuplicateCount(string s1)
    {
      Console.WriteLine($"`{s1}` -> duplicates: {DuplicateCount(s1)}");
    }

    static int DuplicateCount(string s1)
    {
      var list = new List<char>();
      int count = 0;

      foreach (var c in s1)
      {
        if (s1.Count(c) > 1 && !list.Contains(c))
          count += 1;

        list.Add(c);
      }

      return count;
    }

    static int Count(this string s1, char c)
    {
      int count = 0;

      foreach (var ch in s1)
        if (c == ch)
          count += 1;

      return count;
    }
  }
}
