using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12
{
	public class ОбработчикПлатежаЭлектроннымКошельком : ОбработчикПлатежа
	{
		protected override void ПроверитьДанные()
		{
			Console.WriteLine("Проверка данных электронного кошелька.");
		}

		protected override void СписатьСумму()
		{
			Console.WriteLine("Списание суммы с электронного кошелька.");
		}
	}
}

