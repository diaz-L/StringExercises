using System;
using System.Collections.Generic;

/*
 * an isogram is a word that has no duplicate letters. Create a function that takes a string and 
 * returns either true or false depending on whether or not it's an "isogram".
 * ignore letter case
 */
namespace ex25
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Algorism", s2 = "PasSword", s3 = "Consecutive";

      PrintEvalIsogram(s1);
      PrintEvalIsogram(s2);
      PrintEvalIsogram(s3);

    }

    static void PrintEvalIsogram(string s1)
    {
      Console.WriteLine($"{s1} -> {IsIsogram(s1)}");
    }

    static bool IsIsogram(string s1)
    {
      var list = new List<char>(s1.Length);
      var word = s1.ToLower();

      foreach (var c in word)
        if (list.Contains(c))
          return false;
        else
          list.Add(c);

      return new String(list.ToArray()) == word;
    }
  }
}
