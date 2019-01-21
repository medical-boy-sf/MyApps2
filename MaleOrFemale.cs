using System;

class MaleOrFemale
{
	public static void Main()
	{
		char gender = char.Parse(Console.ReadLine());
		bool isMale = false;
		bool isFemale = false;

		if (gender == 'm')
		{
			isMale = true;
		}

		else if (gender == 'f')
		{
			isFemale = true;
		} 

		else
		{
			Console.WriteLine("Gender unindentified!");
			return;
		}

		Console.WriteLine($"Is this person male: {isMale}");
		Console.WriteLine($"Is this person female: {isFemale}");
	}
}
