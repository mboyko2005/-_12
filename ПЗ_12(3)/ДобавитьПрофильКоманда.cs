using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class ДобавитьПрофильКоманда : IКоманда
	{
		private ПрофильМенеджер _менеджер;
		private Профиль _профиль;

		public ДобавитьПрофильКоманда(ПрофильМенеджер менеджер, Профиль профиль)
		{
			_менеджер = менеджер;
			_профиль = профиль;
		}

		public void Выполнить()
		{
			_менеджер.ДобавитьПрофиль(_профиль);
		}

		public void Отменить()
		{
			_менеджер.УдалитьПрофиль(_профиль.Id);
		}
	}
}
