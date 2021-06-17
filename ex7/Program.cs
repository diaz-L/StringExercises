using System;
using System.Security.Cryptography;

/*
 * Write a function that validates whether two strings are identical. Make it case insensitive.
 */
namespace ex7
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Say goodnight to the bad guy..",
              s2 = "Say goodnight to the bad guy..",
              s3 = "goodnight to the bad guy";

      var result1 = EqualIgnoreCase(s1, s2);
      var result2 = EqualIgnoreCase(s1, s3);
      var result3 = EqualIgnoreCase(s2, s3);

      Console.WriteLine($"{s1} == {s2} [{result1}]");
      Console.WriteLine($"{s1} == {s3} [{result2}]");
      Console.WriteLine($"{s2} == {s3} [{result3}]");
    }

    static bool EqualIgnoreCase(string s1, string s2)
    {
      return string.Compare(s1, s2, true) == 0 ? true : false;
    }
  }
}
