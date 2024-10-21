using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_2_
{
	public class ОжиданиеВыбораНапиткаСостояние : IСостояние
	{
		private АвтоматПоПродажам _автомат;

		public ОжиданиеВыбораНапиткаСостояние(АвтоматПоПродажам автомат)
		{
			_автомат = автомат;
		}

		public void ВнестиМонету()
		{
			Console.WriteLine("Монета уже внесена.");
		}

		public void ВыбратьНапиток()
		{
			Console.WriteLine("Напиток выбран.");
			_автомат.ТекущееСостояние = _автомат.СостояниеВыдачиНапитка;
		}

		public void ВыдатьНапиток()
		{
			Console.WriteLine("Сначала выберите напиток.");
		}
	}
}
