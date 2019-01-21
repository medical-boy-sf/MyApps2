using System;

class Greeting
{
	public static void Main()
	{
		string name = Console.ReadLine();
		string message = $"Hello, {name}!";
		Console.WriteLine(message);
	}
}
