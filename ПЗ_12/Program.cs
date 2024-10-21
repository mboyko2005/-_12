
using System;

namespace ПЗ_12
{
	class Program
	{
		static void Main(string[] args)
		{
			ОбработчикПлатежа обработчикПлатежа;

			Console.WriteLine("Выберите способ оплаты: 1 - Карта, 2 - Электронный кошелек, 3 - Наличные");
			string выбор = Console.ReadLine();

			switch (выбор)
			{
				case "1":
					обработчикПлатежа = new ОбработчикПлатежаКартой();
					break;
				case "2":
					обработчикПлатежа = new ОбработчикПлатежаЭлектроннымКошельком();
					break;
				case "3":
					обработчикПлатежа = new ОбработчикПлатежаНаличными();
					break;
				default:
					Console.WriteLine("Неверный выбор.");
					return;
			}

			обработчикПлатежа.ОбработатьПлатеж();

			Console.ReadLine();
		}
	}
}
