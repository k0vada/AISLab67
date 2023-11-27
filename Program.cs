using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67
{
    class Program
    {
        private static ViewController viewController = new ViewController();
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("\n\nМЕНЮ ДЕЙСТВИЙ\nВыберите цифру 1-3 для выполнения соответствующего действия\nДля выхода нажмите Esc");
                Console.WriteLine("  1 - Вывести перечень школ\n  2 - Вывести перечень направлений подготовки\n  3 - Вывести направления определенной школы");

                var button = Console.ReadKey(true).Key;
                switch (button)
                {
                    case ConsoleKey.D1:
                        viewController.PrintAllSchools();
                        break;
                    case ConsoleKey.D2:
                        viewController.PrintAllDirections();
                        break;
                    case ConsoleKey.D3:
                        viewController.PrintDirectionsOfSchool();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        Console.WriteLine("\nОшибка ввода, повторите попытку\n");
                        break;
                }
            }

        }
    }
}
