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
    public partial class FormAssignSubject : Form
    {
        public Subject NewSubject { get; private set; }

        private StudentsGroup _group;
        private FieldOfStudy _field;

        public FormAssignSubject(StudentsGroup group, FieldOfStudy field)
        {
            InitializeComponent();

            _group = group ?? throw new ArgumentNullException(nameof(group));
            _field = field ?? throw new ArgumentNullException(nameof(field));
        }

        private void FormAssignSubject_Load(object sender, EventArgs e)
        {
            foreach (var subject in _field.Subjects)
            {
                cmbSubjectName.Items.Add(subject.Name);
            }

            label1.Text = $"Przypisywanie przedmiotu do grupy: {_group.GroupName}";
        }

        private void btnAssignSubject_Click(object sender, EventArgs e)
        {
            NewSubject = _field.Subjects.FirstOrDefault(s => s.Name == cmbSubjectName.SelectedItem.ToString());

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
