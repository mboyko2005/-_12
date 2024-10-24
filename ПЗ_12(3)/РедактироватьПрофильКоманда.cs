﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class РедактироватьПрофильКоманда : IКоманда
	{
		private ПрофильМенеджер _менеджер;
		private Профиль _старыйПрофиль;
		private Профиль _новыйПрофиль;

		public РедактироватьПрофильКоманда(ПрофильМенеджер менеджер, Профиль новыйПрофиль)
		{
			_менеджер = менеджер;
			_новыйПрофиль = новыйПрофиль;
			_старыйПрофиль = _менеджер.НайтиПрофиль(_новыйПрофиль.Id);
		}

		public void Выполнить()
		{
			_менеджер.ОбновитьПрофиль(_новыйПрофиль);
		}

		public void Отменить()
		{
			_менеджер.ОбновитьПрофиль(_старыйПрофиль);
		}
	}
}
