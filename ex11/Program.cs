using System;
using System.Linq;

/*
 * Create a function that takes a string and returns the number of words. The string will be a sentence.
 */
namespace ex11
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Just an example here, move along.",
             s2 = "This is a test",
             s3 = " ";

      Console.WriteLine($"[{s1}] => count: {WordCount(s1)}");
      Console.WriteLine($"[{s2}] => count: {WordCount(s2)}");
      Console.WriteLine($"[{s3}] => count: {WordCount(s3)}");
    }

    static int WordCount(string sentence)
    {
      return sentence
                .Split(new char[] { ' ', '\t', '\n' })
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Count();
    }
  }
}
