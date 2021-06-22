using System;
using System.Security.Cryptography;

/*
 * Create a function that returns 'true' if a string contains only uppercase letters or only lowercase letters
 */
namespace ex14
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "hello", s2 = "HELLO", s3 = "Hello", s4 = "ketcHUp";

      Console.WriteLine("`{0}` contains same case {1}", s1, SameCase(s1));
      Console.WriteLine("`{0}` contains same case {1}", s2, SameCase(s2));
      Console.WriteLine("`{0}` contains same case {1}", s3, SameCase(s3));
      Console.WriteLine("`{0}` contains same case {1}", s4, SameCase(s4));
    }

    static bool SameCase(string s1)
    {
      Func<char, bool> IsSameCase = char.IsLower(s1[0])
                                      ? c => char.IsLower(c)
                                      : c => char.IsUpper(c);

      foreach (var c in s1)
        if (!IsSameCase(c))
        {
          return false;
        }

      return true;
    }
  }
}
