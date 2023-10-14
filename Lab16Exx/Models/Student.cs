using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Exx.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public Majors Specializare { get; set; }
        public string LastName { get; set; }
        
        public override string ToString()
        {
            return $"Studentul : {FirstName} {LastName} are varsta de {Age} cu specializarea:{Specializare}";
        }

    }
}
