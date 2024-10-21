using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_2_
{
	public class ОжиданиеМонетСостояние : IСостояние
	{
		private АвтоматПоПродажам _автомат;

		public ОжиданиеМонетСостояние(АвтоматПоПродажам автомат)
		{
			_автомат = автомат;
		}

		public void ВнестиМонету()
		{
			Console.WriteLine("Монета внесена.");
			_автомат.ТекущееСостояние = _автомат.СостояниеОжиданияВыбораНапитка;
		}

		public void ВыбратьНапиток()
		{
			Console.WriteLine("Сначала внесите монету.");
		}

		public void ВыдатьНапиток()
		{
			Console.WriteLine("Сначала внесите монету и выберите напиток.");
		}
	}
}
