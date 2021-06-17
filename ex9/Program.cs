using System;

/*
 * create a function that returns "lower" if all letters are lowercase,
 * returns "upper" is all letters are uppercase, "mixed" for any mix of the two
 */
namespace ex9
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "whisper...", s2 = "SHOUT!", s3 = "Indoor Voice", s4 = "12 Twist and Shout";

      Console.WriteLine($"{s1} case: [ {GetCase(s1)} ]");
      Console.WriteLine($"{s2} case: [ {GetCase(s2)} ]");
      Console.WriteLine($"{s3} case: [ {GetCase(s3)} ]");
      Console.WriteLine($"{s4} case: [ {GetCase(s4)} ]");
    }

    static string GetCase(string s1)
    {
      if (IsLower(s1))
        return "lower";
      else if (IsUpper(s1))
        return "upper";
      else
        return "mixed";
    }

    static bool IsLower(string s1)
    {
      foreach (char c in s1)
        if (char.IsLetter(c) && char.IsUpper(c)) return false;

      return true;
    }

    static bool IsUpper(string s1)
    {
      foreach (char c in s1)
        if (char.IsLetter(c) && char.IsLower(c)) return false;

      return true;
    }
  }
}
