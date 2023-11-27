using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67
{
    public class DataController
    {
        public void AddSchool(Model.School school)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Schools.Add(school);
                db.SaveChanges();
            }
        }

        public List<Model.Direction> DirectionsOfSchool(Guid schoolId)
        {
            List<Model.Direction> directions;
            using(DataBaseContext db = new DataBaseContext())
            {
                directions = db.Schools.Where(s => s.Id == schoolId).Include(s => s.Directions).First().Directions.ToList();
            }
            return directions;
        }

        public List<Model.Direction> SelectAllDirections()
        {
            List<Model.Direction> directions;
            using(DataBaseContext db = new DataBaseContext())
            {
                directions = db.Directions.ToList();
            }
            return directions;
        }

        public List<Model.School> SelectAllSchools()
        {
            List<Model.School> schools;
            using (DataBaseContext db = new DataBaseContext())
            {
                schools = db.Schools.ToList();
            }
            return schools;
        }
    }
}
