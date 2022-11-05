using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tortiki
{
    internal class Menu
    {
        static void OtherMenu(int position, int value, string order)
        {
            int point = 0;
            string[] othermenu = new[] { "Форма торта", "Размер торта", "Вкус коржей",
                "Количество коржей", "Глазурь", "Декор", "Конец заказа" };
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            foreach (string item in othermenu)
            {
                Console.SetCursorPosition(3, point);
                Console.WriteLine(item);
                point++;
            }
            Console.WriteLine("-------------------");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine($"Сумма заказа: {value}");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine($"Ваш заказ: {order}");
        }
        static void DopMenu(Zakaz menu, int position)
        {
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(menu.part[0]);
            Console.SetCursorPosition(3, 1);
            Console.WriteLine(menu.part[1]);
            Console.SetCursorPosition(3, 2);
            Console.WriteLine(menu.part[2]);
            Console.SetCursorPosition(3, 3);
            Console.WriteLine(menu.part[3]);
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        public static void MenuOut()
        {
            int page = 0;
            string order = "";
            int position = 0;
            int value = 0;

            Zakaz form = new()
            {
                part = new[] { "Круг", "Квадрат", "Прямоугольник", "Сердечко" },
                price = new[] { 500, 600, 650, 700 }
            };
            Zakaz size = new()
            {
                part = new[] { "Маленький", "Средний", "Большой", "Very big" },
                price = new[] { 750, 1000, 1400, 1900}
            };
            Zakaz taste = new()
            {
                part = new[] { "Шоколадный", "Малиновый", "Ванильный", "Карамельный" },
                price = new[] { 150, 250, 300, 400 }
            };
            Zakaz sum = new()
            {
                part = new[] { "1 корж", "2 коржа", "3 коржа", "4 коржа" },
                price = new[] { 200, 400, 600, 800 }
            };
            Zakaz glaze = new()
            {
                part = new[] { "Шоколад", "Карамельная", "Молочная", "Шоколадно-сливочная" },
                price = new[] { 100, 150, 220, 300 }
            };
            Zakaz decor = new()
            {
                part = new[] { "Вафельная крошка", "Мармеладная", "Шоколадная", "Конфетная" },
                price = new[] { 50, 70, 90, 130 }
            };
            OtherMenu(position, value, order);
            while(true)
            {
                ConsoleKeyInfo knopka = Console.ReadKey();
                switch (knopka.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (page == 0)
                            {
                                if (position > 0)
                                {
                                    Console.Clear();
                                    position--;
                                    OtherMenu(position, value, order);
                                }
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (page == 0)
                            {
                                if (position < 6)
                                {
                                    Console.Clear();
                                    position++;
                                    OtherMenu(position, value, order);
                                }
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            while (knopka.Key != ConsoleKey.Escape)
                            {
                                if (page == 0)
                                {
                                    switch (position)
                                    {
                                        case 0:
                                            page = 1;
                                            Console.Clear();
                                            DopMenu(form, position = 0);
                                            break;
                                        case 1:
                                            page = 2;
                                            Console.Clear();
                                            DopMenu(size, position = 0);
                                            break;
                                        case 2:
                                            page = 3;
                                            Console.Clear();
                                            DopMenu(taste, position = 0);
                                            break;
                                        case 3:
                                            page = 4;
                                            Console.Clear();
                                            DopMenu(sum, position = 0);
                                            break;
                                        case 4:
                                            page = 5;
                                            Console.Clear();
                                            DopMenu(glaze, position = 0);
                                            break;
                                        case 5:
                                            page = 6;
                                            Console.Clear();
                                            DopMenu(decor, position = 0);
                                            break;
                                        case 6:
                                            position = 1;
                                            OrderOut(order, value);
                                            Console.Clear();
                                            Console.SetCursorPosition(3, 0);
                                            Console.WriteLine("Хотите сделать еще один заказ?");
                                            Console.SetCursorPosition(3, 1);
                                            Console.WriteLine("Да");
                                            Console.SetCursorPosition(3, 2);
                                            Console.WriteLine("Нет");
                                            Console.SetCursorPosition(0, position);
                                            Console.WriteLine("->");
                                            while (true)
                                            {
                                                knopka = Console.ReadKey();
                                                switch (knopka.Key)
                                                {
                                                    case ConsoleKey.DownArrow:
                                                        if (position < 2)
                                                        {
                                                            Console.Clear();
                                                            Console.SetCursorPosition(3, 0);
                                                            Console.WriteLine("Хотите сделать еще один заказ?");
                                                            Console.SetCursorPosition(3, 1);
                                                            Console.WriteLine("Да");
                                                            Console.SetCursorPosition(3, 2);
                                                            Console.WriteLine("Нет");
                                                            Console.SetCursorPosition(0, position);
                                                            position++;
                                                            Console.SetCursorPosition(0, position);
                                                            Console.WriteLine("->");
                                                        }
                                                        break;
                                                    case ConsoleKey.UpArrow:
                                                        if (position > 1)
                                                        {
                                                            Console.Clear();
                                                            Console.SetCursorPosition(3, 0);
                                                            Console.WriteLine("Хотите сделать еще один заказ?");
                                                            Console.SetCursorPosition(3, 1);
                                                            Console.WriteLine("Да");
                                                            Console.SetCursorPosition(3, 2);
                                                            Console.WriteLine("Нет");
                                                            Console.SetCursorPosition(0, position);
                                                            position--;
                                                            Console.SetCursorPosition(0, position);
                                                            Console.WriteLine("->");
                                                        }
                                                        break;
                                                    case ConsoleKey.Enter:
                                                        if (position == 1)
                                                        {
                                                            MenuOut();
                                                        }
                                                        else if (position == 2)
                                                        {
                                                            Environment.Exit(0);
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                    }
                                }
                                else if (page != 0 && page != 7)
                                {
                                    Zakaz x;
                                    knopka = Console.ReadKey();
                                    if (page == 1)
                                    {
                                        x = form;
                                    }
                                    else if (page == 2)
                                    {
                                        x = size;
                                    }
                                    else if (page == 3)
                                    {
                                        x = taste;
                                    }
                                    else if (page == 4)
                                    {
                                        x = sum;
                                    }
                                    else if (page == 5)
                                    {
                                        x = glaze;
                                    }
                                    else
                                    {
                                        x = decor;
                                    }
                                    switch (knopka.Key)
                                    {
                                        case ConsoleKey.UpArrow:
                                            if (position > 0)
                                            {
                                                Console.Clear();
                                                position--;
                                                DopMenu(x, position);
                                            }
                                            break;
                                        case ConsoleKey.DownArrow:
                                            if (position < 3)
                                            {
                                                Console.Clear();
                                                position++;
                                                DopMenu(x, position);
                                            }
                                            break;
                                        case ConsoleKey.Enter:
                                            if (position == 0)
                                            {
                                                Console.SetCursorPosition(1, 5);
                                                Console.WriteLine("Успешно добавлено");
                                                value += x.price[0];
                                                order += x.part[0] + ", ";
                                            }
                                            else if (position == 1)
                                            {
                                                Console.SetCursorPosition(1, 5);
                                                Console.WriteLine("Успешно добавлено");
                                                value += x.price[1];
                                                order += x.part[1] + ", ";
                                            }
                                            else if (position == 2)
                                            {
                                                Console.SetCursorPosition(1, 5);
                                                Console.WriteLine("Успешно добавлено");
                                                value += x.price[2];
                                                order += x.part[2] + ", ";
                                            }
                                            else if (position == 3)
                                            {
                                                Console.SetCursorPosition(1, 5);
                                                Console.WriteLine("Успешно добавлено");
                                                value += x.price[3];
                                                order += x.part[3] + ", ";
                                            }
                                            break;
                                    }
                                }
                            }
                            Console.Clear();
                            page = 0;
                            Console.SetCursorPosition(0, position);
                            Console.WriteLine("->");
                            OtherMenu(position, value, order);
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        static void OrderOut(string order, int amount)
        {
            Console.Clear();
            string ordertext = $"\nЗаказ от {DateTime.Now}\n" + $"\tЗаказ: {order}\n\tЦена: {amount} Рублей";
            if (File.Exists("C:\\Users\\Igor\\Desktop\\Заказ.txt"))
            {
                File.AppendAllText("C:\\Users\\Igor\\Desktop\\Заказ.txt", ordertext);
            }
            else
            {
                var bill = File.Create("C:\\Users\\Igor\\Desktop\\Заказ.txt");
                bill.Close();
                File.AppendAllText("C:\\Users\\Igor\\Desktop\\Заказ.txt", ordertext);
            };
        }
    }
}
