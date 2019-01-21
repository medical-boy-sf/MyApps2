/*
	Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.
*/

using System;

class SumOrPoduct
{
	public static void Main()
	{
		string choice = Console.ReadLine();
		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		int product = 1;

		if (choice == "sum")
		{
			for (int i = 1; i <= n; i++)
			{
				sum += i;
			}

			Console.WriteLine($"Sum: {sum}");
		}

		else if (choice == "product")
		{
			 for (int i = 1; i <= n; i++)
			 	{
					product *= i;
				}

				Console.WriteLine($"Product: {product}");
		}

	}
}
