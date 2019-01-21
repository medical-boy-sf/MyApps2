/*
	Write a program that asks the user for their name and greets only the users Alice and Bob.
*/

using System;

class GreetingAliceAndBob
{
	public static void Main()
	{
		string name = Console.ReadLine();
		if (name == "Alice" || name == "Bob") 
		{
			Console.WriteLine($"Hello, {name}!");
		}
	}
}
