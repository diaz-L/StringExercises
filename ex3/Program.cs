using System;

/*
 * Write a function that returns the length of a string. Make your function recursive.
 */
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
		string s1 = "ehlo cruel world", s2 = "goodbye";
				
		Console.WriteLine($"s1 length: {Length(s1)}");
		Console.WriteLine($"s2 length: {Length(s2)}");
        }

	static int Length(string str)
	{
		if (str.Length == 0) return 0;

		return 1 + Length(str.Substring(1));
	}
    }
}
