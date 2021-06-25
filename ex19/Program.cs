using System;

/*
 * create a function that takes a string and repeats the last character 'n' number of times
 */
namespace ex19
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "hello", s2 = "hey", s3 = "execuse me, what?";

      PrintModifyString(s1, 3);
      PrintModifyString(s2, 6);
      PrintModifyString(s3, 5);

      try
      {
        PrintModifyString("", 2);
        PrintModifyString(null, 2);
      }
      catch (Exception)
      {
        Console.WriteLine(">>exception caught for empty or null<<");
      }
    }

    static void PrintModifyString(string s1, int n)
    {
      Console.WriteLine($"`{s1}` -> `{ModifyLast(s1, n)}`");
    }

    static string ModifyLast(string s1, int n)
    {
      if (string.IsNullOrEmpty(s1))
        throw new ArgumentException("string null or empty");

      int lastIndex = s1.Length - 1;

      return s1.Substring(0, lastIndex) + new String(s1[lastIndex], n);
    }
  }
}
