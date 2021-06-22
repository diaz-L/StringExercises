using System;
using System.Text;

/*
 * create a function that repeats each character 'n' times
 */
namespace ex17
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "mice", s2 = "hello", s3 = "stop";

      PrintRepeats(s1, 5);
      PrintRepeats(s2, 3);
      PrintRepeats(s3, 1);
    }

    static void PrintRepeats(string s1, int count)
    {
      Console.WriteLine($"original: `{s1}`");
      Console.WriteLine($"repeat_char: `{Repeat(s1, count)}`");
      Console.WriteLine($"count: {count}");
      Console.WriteLine();
    }

    static string Repeat(string s1, int count)
    {
      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < s1.Length; i++)
        sb.Append(s1[i], count);

      return sb.ToString();
    }
  }
}
