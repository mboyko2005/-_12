using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class КомандныйМенеджер
	{
		private Stack<IКоманда> _история = new Stack<IКоманда>();

		public void ВыполнитьКоманду(IКоманда команда)
		{
			команда.Выполнить();
			_история.Push(команда);
		}

		public void ОтменитьПоследнююКоманду()
		{
			if (_история.Count > 0)
			{
				var команда = _история.Pop();
				команда.Отменить();
			}
			else
			{
				Console.WriteLine("Нет команд для отмены.");
			}
		}
	}
}
