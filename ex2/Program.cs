using System;
using System.Text;

/*
 * Create a method that takes any given number of string and concatenates them
 */
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
		string s1 = "first", s2 = "second", s3 = "third", space = " ", wildcard = "*";

		Console.WriteLine(Concat(s1, space, s2));
		Console.WriteLine(Concat(s1, space, s2, space, s3));
		Console.WriteLine(Concat(space, space, s1, space, s2));
		Console.WriteLine(Concat(wildcard, s1, space, s2, space, s3, wildcard));
        }

	static string Concat(params string[] args)
	{
		StringBuilder sb = new StringBuilder();

		foreach (var arg in args)
			sb.Append(arg);

		return sb.ToString();					
	}
    }
}
