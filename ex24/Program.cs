using System;

/*
 * given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, 
 * and vice versa.
 */
namespace ex24
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "Happy Birthday", s2 = "MANY THANKS",
             s3 = "sPoNtAnEoUs", s4 = string.Empty,
             s5 = null;

      PrintResultsOfReverseCase(s1);
      PrintResultsOfReverseCase(s2);
      PrintResultsOfReverseCase(s3);
      PrintResultsOfReverseCase(s4);
      PrintResultsOfReverseCase(s5);
    }

    static void PrintResultsOfReverseCase(string s1)
    {
      Console.WriteLine($"`{s1 ?? "null"}` -> `{ReverseCase(s1)}`");
    }

    static string ReverseCase(string s1)
    {
      if (string.IsNullOrEmpty(s1))
        return string.Empty;

      char[] list = s1.ToCharArray();

      for (int i = 0; i < list.Length; i++)
        if (char.IsLetter(list[i]))
        {
          if (char.IsUpper(list[i]))
            list[i] = char.ToLower(list[i]);
          else
            list[i] = char.ToUpper(list[i]);
        }

      return new String(list);
    }
  }
}
