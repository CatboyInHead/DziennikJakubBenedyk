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
    public partial class FormEditStudentsGrades : Form
    {
        public Student Student { get; set; }
        public University University { get; set; }

        public FormEditStudentsGrades()
        {
            InitializeComponent();
        }

        public FormEditStudentsGrades(Student student, University university) : this()
        {
            Student = student ?? throw new ArgumentNullException(nameof(student));
            University = university ?? throw new ArgumentNullException(nameof(university));
        }

        private void FormEditStudentsGrades_Load(object sender, EventArgs e)
        {
            if (Student == null)
            {
                MessageBox.Show("Brak informacji o studencie. Formularz zostanie zamknięty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lbStudentsInfo.Text = $"{Student.LastName} {Student.Name} {Student.StudentsID}";

            SetupGradesDgv();
            RefreshGradesDgv();
        }

        private void SetupGradesDgv()
        {
            dgvGrades.Columns.Clear();
            dgvGrades.Columns.Add("Subject", "Przedmiot");
            dgvGrades.Columns.Add("Value", "Ocena");
            dgvGrades.Columns.Add("Description", "Opis");
        }


        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (Student == null)
            {
                MessageBox.Show("Nie wybrano studenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new FormAddGrade(Student, University))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (Student.Grades == null)
                        Student.Grades = new List<Grade>();

                    

                    Student.Grades.Add(new Grade
                    {
                        Subject = form.Subject,
                        Value = form.Value,
                        Description = form.Description
                    });

                    RefreshGradesDgv();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RefreshGradesDgv()
        {
            dgvGrades.Rows.Clear();

            if (Student == null || Student.Grades == null)
                return;

            if (Student.Grades.Count > 0)
                foreach (var grade in Student.Grades)
                    dgvGrades.Rows.Add(grade.Subject.Name, grade.Value, grade.Description);
        }
    }
}
