using System;

/*
 * create a function that takes a string and returns it in reverse order
 */
namespace ex15
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Hello World", s2 = "The quick brown fox.", s3 = "Edabit is really helpful!";

      PrintReverse(s1);
      PrintReverse(s2);
      PrintReverse(s3);
    }

    static void PrintReverse(string s1)
    {
      Console.WriteLine($"original: `{s1}`");
      Console.WriteLine($"reverse: `{Reverse(s1)}`");
      Console.WriteLine();
    }

    static string Reverse(string s1)
    {
      char[] charList = new char[s1.Length];

      for (int i = s1.Length - 1, j = 0; i >= 0; i--, j++)
        charList[j] = s1[i];

      return new String(charList);
    }
  }
}
