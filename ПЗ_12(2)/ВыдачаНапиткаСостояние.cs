using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_2_
{
	public class ВыдачаНапиткаСостояние : IСостояние
	{
		private АвтоматПоПродажам _автомат;

		public ВыдачаНапиткаСостояние(АвтоматПоПродажам автомат)
		{
			_автомат = автомат;
		}

		public void ВнестиМонету()
		{
			Console.WriteLine("Подождите, идет выдача напитка.");
		}

		public void ВыбратьНапиток()
		{
			Console.WriteLine("Подождите, идет выдача напитка.");
		}

		public void ВыдатьНапиток()
		{
			Console.WriteLine("Ваш напиток выдан. Спасибо!");
			_автомат.ТекущееСостояние = _автомат.СостояниеОжиданияМонет;
		}
	}
}
