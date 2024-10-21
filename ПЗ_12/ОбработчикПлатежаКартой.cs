using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ПЗ_12
{
	public class ОбработчикПлатежаКартой : ОбработчикПлатежа
	{
		protected override void ПроверитьДанные()
		{
			Console.WriteLine("Проверка данных карты.");
		}

		protected override void СписатьСумму()
		{
			Console.WriteLine("Списание суммы с карты.");
		}
	}
}

