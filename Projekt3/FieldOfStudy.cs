using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projekt3
{
    public class FieldOfStudy
    {
        public string FieldName { get; set; }
        public ModeOfStudy Mode {  get; set; }

        public List<StudentsGroup> Groups { get; set; } = new List<StudentsGroup>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        internal FieldOfStudy(string fieldName, ModeOfStudy mode)
        {
            FieldName = fieldName;
            Mode = mode;
        }

        public FieldOfStudy() {}

        public void AddGroup(StudentsGroup group)
        {
            Groups.Add(group);
        }

        public void RemoveGroup(string groupName)
        {
            foreach (var group in Groups)
                if (group.GroupName.Equals(groupName))
                    Groups.Remove(group);
        }
    }
}
