using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67
{
    public class DataController
    {
        public void Insert(Model.School school)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Schools.Add(school);
                db.SaveChanges();
            }
        }

        public List<Model.School> SelectAll()
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
