using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67
{
    class Program
    {
        static void Main(string[] args)
        {
            DataController dataController = new DataController();

            Parser parser = new Parser();

            List<Model.School> schools;

            try
            {
                schools = parser.GetSchools();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для завершения нажмитие на любую кнопку.");
                Console.ReadKey();
                return;
            }

            foreach (Model.School school in schools)
            {
                Console.WriteLine("Название:\n  " + school.Name + "\nКорпус:\n  " + school.Campus + "\nАдресс:\n  " + school.Address + "\nТелефон:\n  " + school.Phone);
                Console.WriteLine();

                dataController.Insert(school);
            }

            Console.WriteLine("Для завершения нажмитие на любую кнопку.");
            Console.ReadKey();
        }
    }
}
