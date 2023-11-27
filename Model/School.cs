using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67.Model
{
    public class School
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Campus { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
