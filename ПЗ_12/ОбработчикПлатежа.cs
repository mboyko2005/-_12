using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ПЗ_12
{
	public abstract class ОбработчикПлатежа
	{
		// Шаблонный метод
		public void ОбработатьПлатеж()
		{
			ПроверитьДанные();
			СписатьСумму();
			ОтправитьКвитанцию();
		}

		protected abstract void ПроверитьДанные();
		protected abstract void СписатьСумму();

		protected virtual void ОтправитьКвитанцию()
		{
			Console.WriteLine("Квитанция отправлена клиенту.");
		}
	}
}

