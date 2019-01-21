/*
	Write a program that asks the user for a number n and prints the sum of the numbers 1 to n. Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
*/

using System;

class SumNumber1ToNDivisibleBy3or5
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int sum = 0;

		for (int i = 1; i <= n; i++)
		{
			if (i % 3 == 0 || i % 5 == 0) 
			{
				sum += i;
			}
		}

		Console.WriteLine($"The sum of all number from 1 to N divisible by 3 or 5 is {sum}");
	}
}
