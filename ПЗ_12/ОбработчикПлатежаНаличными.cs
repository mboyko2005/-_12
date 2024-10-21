using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ПЗ_12
{
	public class ОбработчикПлатежаНаличными : ОбработчикПлатежа
	{
		protected override void ПроверитьДанные()
		{
			Console.WriteLine("Проверка наличных средств.");
		}

		protected override void СписатьСумму()
		{
			Console.WriteLine("Прием наличных средств.");
		}

		protected override void ОтправитьКвитанцию()
		{
			Console.WriteLine("Выдача квитанции клиенту.");
		}
	}
}

