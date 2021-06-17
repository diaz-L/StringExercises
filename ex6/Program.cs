using System;
using System.Text;
using System.Diagnostics;

/*
 * create a function that adds a string to each member in an array
 * overload to use StringBuilder
 * measure elapsed time to perform task for both types
 */
namespace ex6
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] listOne = { "clever", "meek", "hurried", "nice" };
      StringBuilder[] listTwo = {
          new StringBuilder("clever"),
          new StringBuilder("meek"),
          new StringBuilder("hurried"),
          new StringBuilder("nice")
       };

      Stopwatch sw = new Stopwatch();

      Console.WriteLine("using System.String:");
      PrintList(listOne);
      sw.Start();
      var results = AppendEnding(listOne, "ly");
      sw.Stop();
      PrintList(results);
      Console.WriteLine($"elapsed time: {sw.Elapsed}");

      Console.WriteLine();

      Console.WriteLine("using System.Text.StringBuilder:");
      PrintList(listTwo);
      sw.Reset();
      sw.Start();
      AppendEnding(listTwo, "ly");
      sw.Stop();
      PrintList(listTwo);
      Console.WriteLine($"elapsed time: {sw.Elapsed}");

    }

    static void PrintList<T>(T[] list)
    {
      Console.Write("[ ");
      foreach (var item in list)
        Console.Write($"{item} ");
      Console.WriteLine("]");
    }

    static string[] AppendEnding(string[] list, string ending)
    {
      string[] workList = new string[list.Length];

      for (var i = 0; i < list.Length; i++)
      {
        workList[i] = string.Concat(list[i], ending);
      }

      return workList;
    }

    static void AppendEnding(StringBuilder[] list, string ending)
    {
      foreach (var item in list)
        item.Append(ending);
    }
  }
}
