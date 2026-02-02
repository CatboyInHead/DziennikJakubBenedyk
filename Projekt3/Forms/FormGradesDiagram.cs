using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3.Forms
{
    public partial class FormGradesDiagram : Form
    {
        public StudentsGroup Group {  get; private set; }

        public FormGradesDiagram(StudentsGroup group)
        {
            InitializeComponent();

            Group = group;
        }

        private void FormGradesDiagram_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();

            foreach (var subject in Group.AssignedSubjects)
            {
                var newTabPage = new TabPage(subject.Name);

                tabControl1.TabPages.Add(newTabPage);

                newTabPage.Name = newTabPage.Text = subject.Name;
            }
        }
    }
}
