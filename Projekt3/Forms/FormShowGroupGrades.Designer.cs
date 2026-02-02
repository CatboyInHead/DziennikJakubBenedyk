namespace Projekt3.Forms
{
    partial class FormShowGroupGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGradeEditor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGradeEditor).BeginInit();
            SuspendLayout();
            // 
            // dgvGradeEditor
            // 
            dgvGradeEditor.AllowUserToAddRows = false;
            dgvGradeEditor.AllowUserToDeleteRows = false;
            dgvGradeEditor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGradeEditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradeEditor.Location = new Point(12, 53);
            dgvGradeEditor.Name = "dgvGradeEditor";
            dgvGradeEditor.ReadOnly = true;
            dgvGradeEditor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradeEditor.Size = new Size(776, 345);
            dgvGradeEditor.TabIndex = 10;
            // 
            // FormShowGroupGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGradeEditor);
            Name = "FormShowGroupGrades";
            Text = "Oceny grupy";
            Load += FormGroupGradesEditor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGradeEditor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGradeEditor;
    }
}