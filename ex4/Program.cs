using System;

/*
 * Write a function that takes a string and returns it as an integer
 */
namespace ex4
{
  class Program
  {
    static void Main(string[] args)
    {
      string num1 = "17", num2 = "27.99", num3 = "", num4 = "abc";

      try
      {
        Console.WriteLine(ToInt(num1));
        Console.WriteLine(ToInt(num2));
        Console.WriteLine(ToInt(num3));
        Console.WriteLine(ToInt(num4));
      }
      catch (NotANumberException e)
      {
        Console.WriteLine("Failed to convert string to integer");
        Console.WriteLine(e.ToString());
      }

    }

    static int ToInt(string num)
    {
      int length;
      for (length = 0; length < num.Length; length++)
      {
        if (!char.IsDigit(num[length]))
          break;
      }

      if (length == 0)
        throw new NotANumberException();
      else
        return int.Parse(num.Substring(0, length));
    }
  }

  public class NotANumberException : Exception { }
}
