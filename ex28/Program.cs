using System;

/*
 * create a function that takes in a sentence and returns the average length of each word in that 
 * sentence. Round your result to two decimal places.
 */
namespace ex28
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "A B C.",
        s2 = "What a gorgeous day.",
        s3 = "Dude, this is so awesome!",
        s4 = "Have you ever wondered what Saturn looks like?",
        s5 = "";

      PrintAverageWordLength(s1);
      PrintAverageWordLength(s2);
      PrintAverageWordLength(s3);
      PrintAverageWordLength(s4);
      PrintAverageWordLength(s5);
    }

    static void PrintAverageWordLength(string s1)
    {
      Console.WriteLine($"`{s1}` -> average_word_length: {AverageWordLength(s1):0.00}");
    }

    static double AverageWordLength(string s1)
    {
      int accWordCount = 0;

      var words = s1.Split(new char[] { ' ', '\t', '\n' });

      foreach (var word in words)
        foreach (var c in word)
          if (char.IsLetter(c))
            accWordCount += 1;

      return accWordCount / (double)words.Length;
    }
  }
}
