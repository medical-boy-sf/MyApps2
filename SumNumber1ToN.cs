/*
	Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
*/

using System;

class SumNumber1ToN 
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += i;
		}

		Console.WriteLine($"The sum is {sum}.");
	}
}
