using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_12_3_
{
	public class Профиль
	{
		public int Id { get; set; }
		public string Имя { get; set; }
		public string ЭлектроннаяПочта { get; set; }

		public Профиль(int id, string имя, string электроннаяПочта)
		{
			Id = id;
			Имя = имя;
			ЭлектроннаяПочта = электроннаяПочта;
		}
	}
}
