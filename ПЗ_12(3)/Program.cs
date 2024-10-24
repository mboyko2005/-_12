namespace ПЗ_12_3_
{
	class Program
	{
		static void Main(string[] args)
		{
			ПрофильМенеджер профильМенеджер = new ПрофильМенеджер();
			КомандныйМенеджер командныйМенеджер = new КомандныйМенеджер();

			while (true)
			{
				Console.WriteLine("\nВыберите действие:");
				Console.WriteLine("1 - Добавить профиль");
				Console.WriteLine("2 - Редактировать профиль");
				Console.WriteLine("3 - Удалить профиль");
				Console.WriteLine("4 - Отменить последнюю команду");
				Console.WriteLine("5 - Показать все профили");
				Console.WriteLine("6 - Выход");

				string выбор = Console.ReadLine();

				switch (выбор)
				{
					case "1":
						Console.Write("Введите ID: ");
						int id = int.Parse(Console.ReadLine());
						Console.Write("Введите имя: ");
						string имя = Console.ReadLine();
						Console.Write("Введите электронную почту: ");
						string почта = Console.ReadLine();

						Профиль новыйПрофиль = new Профиль(id, имя, почта);
						var добавитьКоманда = new ДобавитьПрофильКоманда(профильМенеджер, новыйПрофиль);
						командныйМенеджер.ВыполнитьКоманду(добавитьКоманда);
						break;

					case "2":
						Console.Write("Введите ID профиля для редактирования: ");
						int редактироватьId = int.Parse(Console.ReadLine());
						var существующийПрофиль = профильМенеджер.НайтиПрофиль(редактироватьId);

						if (существующийПрофиль != null)
						{
							Console.Write("Введите новое имя: ");
							string новоеИмя = Console.ReadLine();
							Console.Write("Введите новую электронную почту: ");
							string новаяПочта = Console.ReadLine();

							Профиль обновленныйПрофиль = new Профиль(редактироватьId, новоеИмя, новаяПочта);
							var редактироватьКоманда = new РедактироватьПрофильКоманда(профильМенеджер, обновленныйПрофиль);
							командныйМенеджер.ВыполнитьКоманду(редактироватьКоманда);
						}
						else
						{
							Console.WriteLine("Профиль не найден.");
						}
						break;

					case "3":
						Console.Write("Введите ID профиля для удаления: ");
						int удалитьId = int.Parse(Console.ReadLine());
						var удалитьКоманда = new УдалитьПрофильКоманда(профильМенеджер, удалитьId);
						командныйМенеджер.ВыполнитьКоманду(удалитьКоманда);
						break;

					case "4":
						командныйМенеджер.ОтменитьПоследнююКоманду();
						break;

					case "5":
						профильМенеджер.ПоказатьВсеПрофили();
						break;

					case "6":
						return;

					default:
						Console.WriteLine("Неверный выбор.");
						break;
				}
			}
		}
	}
}
