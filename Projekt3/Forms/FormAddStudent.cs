using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class FormAddStudent : Form
    {
        internal Student NewStudent { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string StudentsID { get; private set; }

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0)
            {
                MessageBox.Show("Nie podano imienia!");
                return;
            }

            if (tbSurname.Text.Length <= 0)
            {
                MessageBox.Show("Nie podano nazwiska!");
                return;
            }

            if (tbStudentsID.Text.Length <= 0)
            {
                MessageBox.Show("Nie podano numeru indeksu!");
                return;
            }

            NewStudent = new Student(tbName.Text, tbSurname.Text, tbStudentsID.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
