using System;

/*
 * create a function that replaces all the vowels in a string with a specified character.
 */
namespace ex21
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "the aardvark", s2 = "minnie mouse", s3 = "shakespeare";

      PrintReplacement(s1, '#');
      PrintReplacement(s2, '?');
      PrintReplacement(s3, '*');
    }

    static void PrintReplacement(string s1, char c)
    {
      Console.WriteLine($"{s1} -> {ReplaceVowels(s1, c)}");
    }

    static string ReplaceVowels(string s1, char c)
    {
      char[] list = s1.ToCharArray();

      for (int i = 0; i < list.Length; i++)
        if (IsVowel(list[i]))
          list[i] = c;

      return new String(list);
    }

    static bool IsVowel(char c)
    {
      switch (c)
      {
        case 'a':
        case 'A':
        case 'e':
        case 'E':
        case 'i':
        case 'I':
        case 'o':
        case 'O':
        case 'u':
        case 'U':
          return true;
      }

      return false;
    }
  }
}
