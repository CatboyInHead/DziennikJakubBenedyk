using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3
{
    public class Student
    {
        //TODO: potencjalnie dodaj date urodzenia
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentsID { get; set; }

        public List<Grade> Grades { get; set; } = new List<Grade>();

        public Student() { }
        public Student(string name, string lastName, string studentsID)
        {
            Name = name;
            LastName = lastName;
            StudentsID = studentsID;
        }
    }
}
