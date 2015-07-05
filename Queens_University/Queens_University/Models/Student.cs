using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens_University.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Average { get; set; }
        public bool IsActive { get; set; }
    }
}
