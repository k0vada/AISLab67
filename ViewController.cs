using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67
{
    class ViewController
    {
        private DataController dataController = new DataController();
        public void PrintDirectionsOfSchool()
        {
            Guid schoolId = new Guid();
            List<Model.School> schools = dataController.SelectAllSchools();
            int index = 0;
            foreach(Model.School school in schools)
            {
                Console.WriteLine("\n" + index + " - " + school.Name+"\n");
                index++;
            }
            Console.Write("\nВведите номер школы:  ");
            string choose = Console.ReadLine();
            Console.WriteLine();

            try
            {
                index = int.Parse(choose);
                try
                {
                    schoolId = schools[index].Id;
                    List<Model.Direction> directions = dataController.DirectionsOfSchool(schoolId);

                    foreach(Model.Direction direction in directions)
                    {
                        Console.WriteLine("\n" + direction.Id + " " + direction.Name + "\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        public void PrintAllDirections()
        {
            Console.WriteLine("\n\nПеречень направлений подготовки:\n");
            foreach (Model.Direction direction in dataController.SelectAllDirections())
            {
                Console.WriteLine("\n" + direction.Id + " " + direction.Name + "\n");
            }
        }
        public void PrintAllSchools()
        {
            Console.WriteLine("\n\nПеречень школ:\n");
            foreach(Model.School school in dataController.SelectAllSchools())
            {
                Console.WriteLine("\nНазвание:\n  " + school.Name + "\nКорпус:\n  " + school.Campus + "\nАдресс:\n  " + school.Address + "\nТелефон:\n  " + school.Phone);
                Console.WriteLine();
            }
        }
    }
}
