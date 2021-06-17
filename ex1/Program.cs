using System;

/*
 * Create a function that returns 'true' if a string is empty and 'false' otherwise
 */
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
		string s1 = "ehlo cruel world!", s2 = string.Empty, s3 = "We are the champions";

		Console.WriteLine($"string s1 is empty: {IsEmpty(s1)}");
		Console.WriteLine($"string s2 is empty: {IsEmpty(s2)}");
		Console.WriteLine($"string s3 is empty: {IsEmpty(s3)}");
        }

	static bool IsEmpty(string text)
	{
		return text.Length > 0 ? true : false;
	}
    }
}
