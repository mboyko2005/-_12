using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class ПрофильМенеджер
	{
		private List<Профиль> _профили = new List<Профиль>();

		public void ДобавитьПрофиль(Профиль профиль)
		{
			_профили.Add(профиль);
			Console.WriteLine($"Профиль {профиль.Имя} добавлен.");
		}

		public void ОбновитьПрофиль(Профиль профиль)
		{
			var существующийПрофиль = НайтиПрофиль(профиль.Id);
			if (существующийПрофиль != null)
			{
				существующийПрофиль.Имя = профиль.Имя;
				существующийПрофиль.ЭлектроннаяПочта = профиль.ЭлектроннаяПочта;
				Console.WriteLine($"Профиль {профиль.Id} обновлен.");
			}
		}

		public void УдалитьПрофиль(int id)
		{
			var профиль = НайтиПрофиль(id);
			if (профиль != null)
			{
				_профили.Remove(профиль);
				Console.WriteLine($"Профиль {профиль.Имя} удален.");
			}
		}

		public Профиль НайтиПрофиль(int id)
		{
			return _профили.FirstOrDefault(p => p.Id == id);
		}

		public void ПоказатьВсеПрофили()
		{
			Console.WriteLine("\nСписок профилей:");
			foreach (var профиль in _профили)
			{
				Console.WriteLine($"ID: {профиль.Id}, Имя: {профиль.Имя}, Почта: {профиль.ЭлектроннаяПочта}");
			}
		}
	}
}
