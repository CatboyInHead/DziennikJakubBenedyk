namespace Projekt3.Forms
{
    public partial class FormGroupGradesEditor : Form
    {
        private StudentsGroup Group { get; set; }
        public FormGroupGradesEditor(StudentsGroup group)
        {
            InitializeComponent();

            Group = group ?? throw new ArgumentNullException(nameof(group));
        }

        private void FormGroupGradesEditor_Load(object sender, EventArgs e)
        {
            SetupDgv();
            UpdateDgv();
        }

        private void SetupDgv()
        {
            dgvGradeEditor.Columns.Clear();
            dgvGradeEditor.Rows.Clear();

            dgvGradeEditor.Columns.Add("StudentID", "ID Studenta");

            foreach (var subject in Group.AssignedSubjects)
                dgvGradeEditor.Columns.Add(subject.Name, subject.Name);
        }

        private void UpdateDgv()
        {
            foreach (var student in Group.Students)
            {
                int rowIndex = dgvGradeEditor.Rows.Add(student.StudentsID);

                DataGridViewRow row = dgvGradeEditor.Rows[rowIndex];

                foreach (var grade in student.Grades)
                {
                    row.Cells[grade.Subject.Name].Value += $"{grade.Value}    ";
                }
            }
        }
    }
}
