using System;

namespace Uppgift_3_17
{

}

 class Program
{
	 static void Main()
	{

		Console.WriteLine("Skriv in två tal");
		int tal1 = int.Parse(Console.ReadLine());
		int tal2 = int.Parse(Console.ReadLine());
		int Addition = 1;
		int Subtraktion = 2;
		int Multiplikation = 3;
		int Division = 4;



		Console.WriteLine("Välj ett räknesätt (1) Addition (2) Subtraktion (3) Multiplikation (4) Division ");
		string välja = Console.ReadLine();

		switch (välja)
		{
			case "1":
				Console.WriteLine(tal1 + tal2);
				break;

			case "2":
				Console.WriteLine(tal1 - tal2);
				break;

			case "3":

				Console.WriteLine(tal1 * tal2);
				break;

			case "4":
				Console.WriteLine(tal1 / tal2);
				break;

		}





	}

}