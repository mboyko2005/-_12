using System;
namespace ПЗ_12_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			АвтоматПоПродажам автомат = new АвтоматПоПродажам();

			while (true)
			{
				Console.WriteLine("\nВыберите действие:");
				Console.WriteLine("1 - Внести монету");
				Console.WriteLine("2 - Выбрать напиток");
				Console.WriteLine("3 - Забрать напиток");
				Console.WriteLine("4 - Выход");

				string выбор = Console.ReadLine();

				switch (выбор)
				{
					case "1":
						автомат.ВнестиМонету();
						break;
					case "2":
						автомат.ВыбратьНапиток();
						break;
					case "3":
						автомат.ВыдатьНапиток();
						break;
					case "4":
						return;
					default:
						Console.WriteLine("Неверный выбор.");
						break;
				}
			}
		}
	}
}
