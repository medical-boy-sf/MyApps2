using System;

class TriangleOfStars 
{
	public static void Main()
	{
		for (int i = 0; i < 5; i++)
		{
			for (int inter = 0; inter < 5 - i - 1; inter += 1)
			{
				Console.Write(" ");
			}

			for (int stars = 0; stars < 2 * i + 1; stars += 1)
			{
				Console.Write("*");
			}

			Console.WriteLine();
		}
	}
}
