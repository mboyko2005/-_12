using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class УдалитьПрофильКоманда : IКоманда
	{
		private ПрофильМенеджер _менеджер;
		private Профиль _профиль;

		public УдалитьПрофильКоманда(ПрофильМенеджер менеджер, int профильId)
		{
			_менеджер = менеджер;
			_профиль = _менеджер.НайтиПрофиль(профильId);
		}

		public void Выполнить()
		{
			_менеджер.УдалитьПрофиль(_профиль.Id);
		}

		public void Отменить()
		{
			_менеджер.ДобавитьПрофиль(_профиль);
		}
	}
}
