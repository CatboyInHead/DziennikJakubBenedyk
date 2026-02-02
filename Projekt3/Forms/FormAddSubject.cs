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
    public partial class FormAddSubject : Form
    {
        public string SubjectName { get; private set; }
        public int ECTS { get; private set; }

        public FormAddSubject()
        {
            InitializeComponent();
        }

        private void FormAddSubject_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SubjectName = tbSubjectName.Text;
            ECTS = int.TryParse(tbECTS.Text, out int ects) ? ects : 0;
            if (ECTS <= 0)
            {
                MessageBox.Show("Podano nieprawidłoą liczbę punktów ECTS");
                return;
            }

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
