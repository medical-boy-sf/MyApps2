using System;

class SumTwoNumbers
{
	static int SumNumbers(int a, int b)
	{
		return a + b;
	}

	public static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine(SumNumbers(a, b));
	}
}
