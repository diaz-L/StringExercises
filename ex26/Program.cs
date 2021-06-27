using System;
using System.Collections.Generic;

/*
 * create a function that takes two strings and returns either true or false depending on whether they're
 * anagrams or not. Should be case insensitive.
 */
namespace ex26
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintIsAnagram("cristian", "Cristina");
      PrintIsAnagram("Dave Barry", "Ray Adverb");
      PrintIsAnagram("Nope", "Note");
      PrintIsAnagram("Apple", "Appeal");
    }

    static void PrintIsAnagram(string s1, string s2)
    {
      Console.WriteLine($"({s1}, {s2}) is anagram: {IsAnagram(s1, s2)}");
    }

    static bool IsAnagram(string s1, string s2)
    {
      var list1 = new List<char>();
      var list2 = new List<char>();

      foreach (var c in s1.ToLower())
      {
        if (!char.IsLetter(c)) continue;
        list1.Add(c);
      }

      foreach (var c in s2.ToLower())
      {
        if (!char.IsLetter(c)) continue;
        list2.Add(c);
      }

      list1.Sort();
      list2.Sort();

      var results1 = new String(list1.ToArray());
      var results2 = new String(list2.ToArray());

      return results1 == results2;
    }
  }
}
