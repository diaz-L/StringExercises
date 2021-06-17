using System;
using System.Text;

/*
 * create a function that takes an array and string and returns the index of string 
 */
namespace ex10
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] arr1 = { "hi", "edabit", "fgh", "abc" },
               arr2 = { "Red", "blue", "Blue", "Green" },
               arr3 = { "a", "g", "y", "d" },
               arr4 = { "Pineapple", "Orange", "Grape", "Apple" };

      string s1 = "fgh", s2 = "blue", s3 = "d", s4 = "Pineapple", s5 = "abc";

      Console.WriteLine($"array: {Print(arr1)}, target: {s1}, index: {IndexOf(arr1, s1)}");
      Console.WriteLine($"array: {Print(arr2)}, target: {s2}, index: {IndexOf(arr2, s2)}");
      Console.WriteLine($"array: {Print(arr3)}, target: {s3}, index: {IndexOf(arr3, s3)}");
      Console.WriteLine($"array: {Print(arr4)}, target: {s4}, index: {IndexOf(arr4, s4)}");
      Console.WriteLine($"array: {Print(arr3)}, target: {s5}, index: {IndexOf(arr3, s5)}");
    }

    static int IndexOf(string[] arr, string s1)
    {
      for (var i = 0; i < arr.Length; i++)
        if (arr[i] == s1) return i;

      return -1;
    }

    static string Print(string[] list)
    {
      StringBuilder output = new StringBuilder();

      output.Append("[ ");
      foreach (var item in list)
        output.Append($"{item} ");
      output.Append("]");

      return output.ToString();
    }
  }
}
