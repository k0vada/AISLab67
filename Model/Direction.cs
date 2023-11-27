using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISLab67.Model
{
    public class Direction
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid? SchoolId { get; set; }
        public School School { get; set; }
    }
}
