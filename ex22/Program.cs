using System;
using System.Collections.Generic;

/*
 * create a function that takes an array of items, removes all duplicate items and returns a new array 
 * in the same sequential order as the old array (minus duplicates).
 */
namespace ex22
{
  class Program
  {
    static void Main(string[] args)
    {
      var numbers = new int[] { 1, 0, 1, 0 };
      var list1 = new string[] { "The", "big", "cat" };
      var list2 = new string[] { "John", "Taylor", "John" };

      PrintReport(numbers);
      PrintReport(list1);
      PrintReport(list2);
      PrintReport(new int[0]);
    }

    static void PrintReport<T>(T[] list)
    {
      PrintList(list);
      Console.Write(" -> ");
      var uniqueList = RemoveDuplicate(list);
      PrintList(uniqueList);
      Console.WriteLine();
    }

    static void PrintList<T>(T[] list)
    {
      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.Write("]");
    }

    static T[] RemoveDuplicate<T>(T[] list)
    {
      var uniqueList = new List<T>(list.Length);

      foreach (var item in list)
        if (!uniqueList.Contains(item))
          uniqueList.Add(item);

      return uniqueList.ToArray();
    }
  }
}
