/*
	Write a program that prints a multiplication table for numbers up to 12.
*/

using System;

class MultiplicationTableUpTo12
{
	public static void Main()
	{
		for (int i = 1; i <= 12; i++)
		{
			for (int j = 1; j <= 10; j++)
			{
				Console.WriteLine($"{i} * {j} = {i * j}");
			}
			Console.WriteLine();
		}
	}
}
