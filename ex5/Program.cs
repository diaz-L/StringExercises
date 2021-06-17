using System;

/*
 * create a function that returns true if a string contains whitespaces
 */
namespace ex5
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "ehlo, cruel world!!", s2 = "abc", s3 = "\tgreetings\t", s4 = string.Empty;

      Console.WriteLine($">>{s1}<< contains whitespace: {HasWhitespace(s1)}");
      Console.WriteLine($">>{s2}<< contains whitespace: {HasWhitespace(s2)}");
      Console.WriteLine($">>{s3}<< contains whitespace: {HasWhitespace(s3)}");
      Console.WriteLine($">>{s4}<< contains whitespace: {HasWhitespace(s4)}");
    }

    static bool HasWhitespace(string str)
    {
      foreach (var c in str)
      {
        if (char.IsWhiteSpace(c)) return true;
      }

      return false;
    }
  }
}
