using System;
using System.Collections.Generic;

/*
 * create a function that takes an array of string and returns the words that are exactly four letters
 */
namespace ex20
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] list1 = { "Tomato", "Potato", "Pair" },
               list2 = { "Kangaroo", "Bear", "Fox" },
               list3 = { "Ryan", "Kieran", "Jason", "Matt" };

      PrintFourLetterArray(list1);
      PrintFourLetterArray(list2);
      PrintFourLetterArray(new string[0]);
      PrintFourLetterArray(list3);

    }

    static void PrintFourLetterArray(string[] list)
    {
      PrintList(list);
      Console.Write(" -> ");
      string[] fourLetterOnly = GetFourLetterWords(list);
      PrintList(fourLetterOnly);
      Console.WriteLine();
    }

    static void PrintList(string[] list)
    {
      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static string[] GetFourLetterWords(string[] words)
    {
      var list = new List<string>();

      foreach (var word in words)
        if (word.Length == 4)
          list.Add(word);

      return list.ToArray();
    }
  }
}
