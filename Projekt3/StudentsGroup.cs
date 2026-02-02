using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace Projekt3
{
    public class StudentsGroup
    {
        public string GroupName { get; set; }
        public int groupID;
        public int Semester { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> AssignedSubjects { get; set; } = new List<Subject>();

        private int numberOfStudents = 0;

        public StudentsGroup() { }

        public StudentsGroup(string groupName, int semester)
        {
            GroupName = groupName;
            //this.groupID = groupID;
            Semester = semester;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
