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
    public partial class FormAddGrade : Form
    {
        public Subject Subject { get; private set; }
        public float Value { get; private set; }
        public string Description { get; private set; }

        public University University { get; private set; }
        public Student Student { get; private set; }

        public FormAddGrade(Student student, University university)
        {
            InitializeComponent();

            if (student == null)
            {
                lbstudentsInfo.Text = "Brak danych o studencie.";
                return;
            }
            University = university ?? throw new ArgumentNullException(nameof(university));
            Student = student ?? throw new ArgumentNullException(nameof(student));

            lbstudentsInfo.Text = $"Oceny {student.Name} {student.LastName} {student.StudentsID}:";
        }

        private void FormAddGrade_Load(object sender, EventArgs e)
        {
            var group = University.Fields.SelectMany(f => f.Groups).FirstOrDefault(g => g.Students.Any(s => s.StudentsID == Student.StudentsID));

            this.Text = $"Dodaj ocenę dla: {Student.Name} {Student.LastName} {Student.StudentsID}";

            foreach (var subject in group.AssignedSubjects)
            {
                cmbSubject.Items.Add(subject.Name);
            }

            if (cmbGrade.Items.Count == 0)
            {
                cmbGrade.Items.AddRange(new object[] { "2.0", "3.0", "3.5", "4.0", "4.5", "5.0" });
            }
            cmbGrade.SelectedIndex = -1;
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            // walidacja
            if (cmbSubject.SelectedItem == null)
            {
                MessageBox.Show("Wybierz przedmiot.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbGrade.SelectedItem == null)
            {
                MessageBox.Show("Wybierz ocenę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var subjectName = cmbSubject.SelectedItem.ToString();


            if (!float.TryParse(cmbGrade.SelectedItem.ToString(), out float parsedValue))
            {
                MessageBox.Show("Nieprawidłowa wartość oceny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Value = parsedValue;
            Description = rtbDescription.Text ?? string.Empty;

            var field = University.Fields.FirstOrDefault(f =>
                        f.Groups.Any(g =>
                        g.Students.Contains(Student)
                        )
                    );

            Subject = field.Subjects.FirstOrDefault(f => f.Name.ToLower() == cmbSubject.SelectedItem.ToString().ToLower());

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
