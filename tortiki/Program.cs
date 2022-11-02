namespace tortiki
{
    internal class Program
    {
        static DateTime date = new DateTime(2022, 10, 10);
        static void Main(string[] args)
        {
            order();
        }
        public static void PodMenu()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  Круг - 500");
            Console.WriteLine("  Квадрат - 600");
            Console.WriteLine("  Прямоугольник - 650");
            Console.WriteLine("  Сердечко - 700");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("->");
        }
        
        public static void Menu(int position)
        {
            Console.Clear();
            Console.WriteLine("Заказ тортов в Подольске без смс и регистрации");
            Console.WriteLine("Выберите параметры вашего торта");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количестов коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("");
            Console.WriteLine($"Цена: ");
            Console.WriteLine($"Ваш торт: "); ;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        public static void order()
        {
            int position = 3;
            Menu(position);
            while (true)
            {
                ConsoleKeyInfo knopka = Console.ReadKey();
                if (knopka.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position < 3)
                    {
                        position++;
                    }
                    else if (position > 9)
                    {
                        position = 9;
                    }
                    Menu(position);
                }
                else if (knopka.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 3)
                    {
                        position = 3;
                    }
                    Menu(position);
                }
                else if (knopka.Key == ConsoleKey.Enter)
                {
                    PodMenu();
                    switch (knopka.Key)
                    {
                        case 0:
                            switch(position)
                            {
                                case 0:
                                if (knopka.Key == ConsoleKey.DownArrow)
                                {
                                    position++;
                                    if (position < 3)
                                    {
                                        position++;
                                    }
                                    else if (position > 9)
                                    {
                                        position = 9;
                                    }
                                    Menu(position);
                                }
                                break;
                            }
                            break;
                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }
    }
}