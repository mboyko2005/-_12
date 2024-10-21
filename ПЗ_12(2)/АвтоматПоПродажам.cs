using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_2_
{
	public class АвтоматПоПродажам
	{
		public IСостояние СостояниеОжиданияМонет { get; private set; }
		public IСостояние СостояниеОжиданияВыбораНапитка { get; private set; }
		public IСостояние СостояниеВыдачиНапитка { get; private set; }

		public IСостояние ТекущееСостояние { get; set; }

		public АвтоматПоПродажам()
		{
			СостояниеОжиданияМонет = new ОжиданиеМонетСостояние(this);
			СостояниеОжиданияВыбораНапитка = new ОжиданиеВыбораНапиткаСостояние(this);
			СостояниеВыдачиНапитка = new ВыдачаНапиткаСостояние(this);

			ТекущееСостояние = СостояниеОжиданияМонет;
		}

		public void ВнестиМонету()
		{
			ТекущееСостояние.ВнестиМонету();
		}

		public void ВыбратьНапиток()
		{
			ТекущееСостояние.ВыбратьНапиток();
		}

		public void ВыдатьНапиток()
		{
			ТекущееСостояние.ВыдатьНапиток();
		}
	}
}
