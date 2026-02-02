using Projekt3.Forms;
using System.Data;

namespace Projekt3
{
    public partial class Form1 : Form
    {
        private University university = new University();

        public Form1()
        {
            InitializeComponent();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dziennik.json");

            university.LoadFieldsOfStudy(path);
            tabControl1.Dock = DockStyle.Fill;
            dgvGroups.Dock = DockStyle.Fill;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudyFields.Dock = DockStyle.Fill;
            dgvSubjects.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupFieldsDgv();
            SetupGroupsDgv();
            SetupStudentsDgv();
            SetupSubjectsDgv();
            SetupSearchDgv();
            RefreshFieldsList();
        }

        private void SetupFieldsDgv()
        {
            dgvStudyFields.Columns.Clear();
            dgvStudyFields.Columns.Add("FieldName", "Nazwa kierunku");
            dgvStudyFields.Columns.Add("Mode", "Tryb studiów");
            dgvStudyFields.Columns.Add("GroupsCounter", "Iloœæ grup");
            dgvStudyFields.Columns.Add("StudentsCounter", "Iloœæ studentów");
        }

        private void SetupGroupsDgv()
        {
            dgvGroups.Columns.Clear();
            dgvGroups.Columns.Add("GroupName", "Nazwa grupy");
            dgvGroups.Columns.Add("Semester", "Semestr");
            dgvGroups.Columns.Add("StudentsCounter", "Iloœæ studentów");
        }

        private void SetupStudentsDgv()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add("StudentsID", "Numer ineksu");
            dgvStudents.Columns.Add("NameAndSurname", "Imiê i nazwisko");
            dgvStudents.Columns.Add("Group", "Grupa");
            dgvStudents.Columns.Add("GradesCounter", "Iloœæ ocen");
        }
        private void SetupSubjectsDgv()
        {
            dgvSubjects.Columns.Clear();
            dgvSubjects.Columns.Add("SubjectName", "Nazwa przedmiotu");
            dgvSubjects.Columns.Add("Field", "Przypisany kierunek");
            dgvSubjects.Columns.Add("Semester", "Semestr");
            dgvSubjects.Columns.Add("Groups", "Przypisane grupy");
        }

        private void SetupSearchDgv()
        {
            dgvSearchList.Columns.Clear();
            dgvSearchList.Columns.Add("StudentsID", "Numer ineksu");
            dgvSearchList.Columns.Add("NameAndSurname", "Imiê i nazwisko");
        }

        private void dgvStudyFields_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedName = dgvStudyFields.Rows[e.RowIndex].Cells["FieldName"].Value.ToString();
            string selectedMode = dgvStudyFields.Rows[e.RowIndex].Cells["Mode"].Value.ToString();

            var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == selectedName.ToLower() && f.Mode.ToString().ToLower() == selectedMode.ToLower());

            tabControl1.SelectTab(1);
            dgvStudents.Rows.Clear();
            dgvGroups.Rows.Clear();
            RefreshGroupsList(field);
            RefreshSubjectsList(field);
        }

        private void dgvGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedGroupName = dgvGroups.Rows[e.RowIndex].Cells["GroupName"].Value.ToString();
            int selectedSemester = Convert.ToInt32(dgvGroups.Rows[e.RowIndex].Cells["Semester"].Value);

            if (dgvStudyFields.CurrentRow == null) return;

            string selectedFieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value?.ToString();

            if (selectedFieldName != null && selectedGroupName != null)
            {
                var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == selectedFieldName.ToLower());

                if (field != null)
                {
                    var group = field.Groups.FirstOrDefault(g => g.GroupName.ToLower() == selectedGroupName.ToLower() && g.Semester == selectedSemester);

                    if (group != null)
                    {
                        tabControl1.SelectTab(2);
                        dgvStudents.Rows.Clear();
                        RefreshStudentsList(group);
                    }
                }
            }
        }

        private void dvgStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvStudents.CurrentRow.Cells["StudentsID"].Value.ToString();

            var student = university.Fields
                            .SelectMany(f => f.Groups)
                            .SelectMany(g => g.Students)
                            .FirstOrDefault(s => s.StudentsID == id);

            EditStudentsGrades(student);
        }

        private void dvgSearchList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvSearchList.CurrentRow.Cells["StudentsID"].Value.ToString();

            var student = university.Fields
                            .SelectMany(f => f.Groups)
                            .SelectMany(g => g.Students)
                            .FirstOrDefault(s => s.StudentsID == id);

            if (student != null)
            {
                string fieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();


                var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == fieldName.ToLower());

                using (var form = new FormEditStudentsGrades(student, university))
                {
                    form.University = university;
                    form.ShowDialog();
                }

                university.UpdateJson();
            }
        }

        private void btnAddStudyField_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddFieldOfStudy())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bool exists = university.Fields.Any(f => f.FieldName == form.NewField.FieldName && f.Mode == form.NewField.Mode);

                    if (exists)
                    {
                        MessageBox.Show($"Kierunek {form.NewField.FieldName} ju¿ istnieje!");
                        return;
                    }

                    university.AddStudyField(form.NewField);
                    RefreshFieldsList();
                    university.UpdateJson();

                    MessageBox.Show($"Pomyœlnie dodano kierunek {form.NewField.FieldName} w trybie {form.NewField.Mode.ToString()}");

                    dgvStudyFields.ClearSelection();
                    dgvStudyFields.Rows[dgvStudyFields.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void btnEditStudentGrades_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Nie wybrano ¿adnego studenta");
                return;
            }

            string studentID = dgvStudents.CurrentRow.Cells["StudentsID"].Value.ToString();

            var student = university.Fields
                            .SelectMany(f => f.Groups)
                            .SelectMany(g => g.Students)
                            .FirstOrDefault(s => s.StudentsID == studentID);

            EditStudentsGrades(student);

            university.UpdateJson();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {

            using (var form = new FormAddGroup())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string selectedFieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();

                    var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == selectedFieldName.ToLower());

                    field.AddGroup(form.NewGroup);
                    RefreshGroupsList(field);
                    university.UpdateJson();

                    MessageBox.Show($"Pomyœlnie dodano grupê {form.NewGroup.GroupName}");

                    dgvGroups.ClearSelection();
                    dgvGroups.Rows[dgvGroups.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows == null)
            {
                MessageBox.Show("Najpierw wybierz grupê!");
                return;
            }

            using (var form = new FormAddStudent())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var student = university.Fields.SelectMany(f => f.Groups).SelectMany(g => g.Students)
                        .FirstOrDefault(s => s.StudentsID == form.NewStudent.StudentsID);
                    if (student != null)
                    {
                        MessageBox.Show($"Student o numerze indeksu {form.NewStudent.StudentsID} ju¿ istnieje!");
                        return;
                    }

                    string selectedFieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();
                    string selectedGroupName = dgvGroups.CurrentRow.Cells["GroupName"].Value.ToString();

                    var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == selectedFieldName.ToLower());

                    if (field != null)
                    {
                        var group = field.Groups.FirstOrDefault(g => g.GroupName.ToLower() == selectedGroupName.ToLower());

                        if (group != null && form.NewStudent != null)
                        {
                            group.AddStudent(form.NewStudent);
                            university.UpdateJson();
                            MessageBox.Show($"Pomyœlnie dodano studenta {form.NewStudent.Name} {form.NewStudent.LastName}");
                            RefreshStudentsList(group);
                        }
                    }
                }
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            var selectedStudentID = dgvStudents.CurrentRow.Cells["StudentsID"].Value.ToString();

            var group = university.Fields
                            .SelectMany(f => f.Groups)
                            .FirstOrDefault(g => g.Students.Any(s => s.StudentsID == selectedStudentID));
            if (group != null)
            {
                var result = MessageBox.Show($"Czy na pewno usun¹æ studenta o ID {selectedStudentID}?", "Potwierdzenie", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    group.RemoveStudent(selectedStudentID);
                    university.UpdateJson();
                    RefreshStudentsList(group);
                }
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddSubject())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var selectedFieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();
                    var field = university.Fields.FirstOrDefault(f => f.FieldName.Equals(selectedFieldName, StringComparison.OrdinalIgnoreCase));

                    if (field != null)
                    {
                        field.Subjects.Add(new Subject { Name = form.SubjectName, ECTS = form.ECTS });
                        university.UpdateJson();
                    }
                    RefreshSubjectsList(field);
                }
            }
        }

        private void btnAssignSubject_Click(object sender, EventArgs e)
        {
            var selectedFieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();
            string selectedGroupName = dgvGroups.CurrentRow.Cells["GroupName"].Value.ToString();

            var field = university.Fields.FirstOrDefault(f => f.FieldName.Equals(selectedFieldName, StringComparison.OrdinalIgnoreCase));
            var group = field.Groups.FirstOrDefault(g => g.GroupName.ToLower() == selectedGroupName.ToLower());

            using (var form = new FormAssignSubject(group, field))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    group.AssignedSubjects.Add(form.NewSubject);
                    university.UpdateJson();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshSearchList();
        }

        private void btnGradesDiagram_Click(object sender, EventArgs e)
        {
            var group = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString().ToLower()).Groups.FirstOrDefault(g => g.GroupName.ToLower() == dgvGroups.CurrentRow.Cells["GroupName"].Value.ToString().ToLower() && g.Semester == (int)dgvGroups.CurrentRow.Cells["Semester"].Value);

            if (group != null)
                using (var form = new FormGradesDiagram(group))
                {
                    form.ShowDialog();
                }
        }

        private void btnEditGroupGrades_Click(object sender, EventArgs e)
        {
            var group = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString().ToLower()).Groups.FirstOrDefault(g => g.GroupName.ToLower() == dgvGroups.CurrentRow.Cells["GroupName"].Value.ToString().ToLower() && g.Semester == (int)dgvGroups.CurrentRow.Cells["Semester"].Value);

            if (group != null)
                using (var form = new FormShowGroupGrades(group))
                {
                    form.ShowDialog();
                }
        }

        private void RefreshFieldsList()
        {
            dgvStudyFields.Rows.Clear();

            var allFields = university.Fields;

            foreach (var field in allFields)
            {
                var totalStudents = field.Groups.SelectMany(g => g.Students).Count();
                dgvStudyFields.Rows.Add(field.FieldName, field.Mode.ToString(), field.Groups.Count, totalStudents);
            }
        }

        public void RefreshGroupsList(FieldOfStudy field)
        {
            dgvGroups.Rows.Clear();

            var allGroups = field.Groups;

            foreach (var group in allGroups)
            {
                dgvGroups.Rows.Add(group.GroupName, group.Semester, group.Students.Count);
            }
        }

        private void RefreshStudentsList(StudentsGroup group)
        {
            dgvStudents.Rows.Clear();

            var allStudents = group.Students;

            foreach (var student in allStudents)
                dgvStudents.Rows.Add(student.StudentsID, $"{student.Name} {student.LastName}", group.GroupName, student.Grades.Count);
        }

        private void RefreshSubjectsList(FieldOfStudy field)
        {
            dgvSubjects.Rows.Clear();

            var allSubjects = field.Subjects;

            foreach (var subject in allSubjects)
            {
                dgvSubjects.Rows.Add(subject.Name, field.FieldName);
            }
        }

        private void RefreshSearchList()
        {
            dgvSearchList.Rows.Clear();

            List<Student> searchResults = university.Fields
                                            .SelectMany(f => f.Groups)
                                            .SelectMany(g => g.Students)
                                            .Where(s =>
                                            s.StudentsID == tbStudentsID.Text
                                            || $"{s.Name} {s.LastName}".ToLower() == tbNameAndLastName.Text.ToLower()).ToList();

            foreach (var student in searchResults)
            {
                dgvSearchList.Rows.Add(student.StudentsID, $"{student.Name} {student.LastName}");
            }
        }

        private void EditStudentsGrades(Student student)
        {
            string fieldName = dgvStudyFields.CurrentRow.Cells["FieldName"].Value.ToString();
            string groupName = dgvGroups.CurrentRow.Cells["GroupName"].Value.ToString();

            var field = university.Fields.FirstOrDefault(f => f.FieldName.ToLower() == fieldName.ToLower());
            var group = field.Groups.FirstOrDefault(g => g.GroupName.ToLower() == groupName.ToLower());

            using (var form = new FormEditStudentsGrades(student, university))
            {
                form.University = university;
                form.ShowDialog();
            }

            university.UpdateJson();

            RefreshStudentsList(group);
        }
    }
}
