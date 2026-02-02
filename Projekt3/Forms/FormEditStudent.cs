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
    public partial class FormEditStudent : Form
    {
        public string StudentsName { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }

        public Student NewStudent { get; private set; }

        public FormEditStudent(Student student)
        {
            InitializeComponent();

            tbName.Text = student.Name;
            tbSurname.Text = student.LastName;
            tbStudentsID.Text = student.StudentsID;
        }

        private void btnEditGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbSurname.Text) || string.IsNullOrWhiteSpace(tbStudentsID.Text))
            {
                MessageBox.Show("Podano niepoprawne dane");
                return; 
            }

            NewStudent.Name = tbName.Text;
            NewStudent.LastName = tbSurname.Text;
            NewStudent.StudentsID = tbStudentsID.Text;


        }
    }
}
