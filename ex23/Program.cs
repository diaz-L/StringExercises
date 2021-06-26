using System;

/*
 * a palindrome is a word that is identical fowards and backwards; creaet a function that checks if given
 * a string if is a palindrome
 */
namespace ex23
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "mom", s2 = "scary", s3 = "reviver", s4 = "stressed";

      CheckIsPalindrome(s1);
      CheckIsPalindrome(s2);
      CheckIsPalindrome(s3);
      CheckIsPalindrome(s4);
      try
      {
        CheckIsPalindrome(null);
      }
      catch (Exception)
      {
        Console.WriteLine("null or empty string handle correctly");
      }
    }

    static void CheckIsPalindrome(string s1)
    {
      Console.WriteLine($"`{s1}` is palindrome -> {IsPalindrome(s1)}");
    }

    static bool IsPalindrome(string s1)
    {
      string reverseStr = Reverse(s1);

      return s1 == reverseStr;
    }

    static string Reverse(string s1)
    {
      if (string.IsNullOrEmpty(s1))
        throw new ArgumentException();

      char[] results = s1.ToCharArray();
      Array.Reverse(results);
      return new String(results);
    }
  }
}
