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
    public partial class FormAddFieldOfStudy : Form
    {
        public FieldOfStudy NewField { get; private set; }

        public FormAddFieldOfStudy()
        {
            InitializeComponent();

            cmbModeOfStudy.DataSource = Enum.GetValues(typeof(ModeOfStudy));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbFieldName.Text))
            {
                NewField = new FieldOfStudy(tbFieldName.Text, (ModeOfStudy)cmbModeOfStudy.SelectedItem);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
