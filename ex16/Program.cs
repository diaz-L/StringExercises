using System;

/*
 * create a function that takes a string and returns a string with space between characters
 */
namespace ex16
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "space", s2 = "far out", s3 = "elongated musk";

      PrintSpaceOut(s1);
      PrintSpaceOut(s2);
      PrintSpaceOut(s3);
    }

    static void PrintSpaceOut(string s1)
    {
      Console.WriteLine($"original: `{s1}`");
      Console.WriteLine($"space_out: `{SpaceMeOut(s1)}`");
      Console.WriteLine();
    }

    static string SpaceMeOut(string s1)
    {
      char[] charList = s1.ToCharArray();

      return string.Join(' ', charList);
    }
  }
}
