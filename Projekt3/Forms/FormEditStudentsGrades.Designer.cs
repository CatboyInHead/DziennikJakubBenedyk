namespace Projekt3.Forms
{
    partial class FormEditStudentsGrades
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
            lbStudentsInfo = new Label();
            dgvGrades = new DataGridView();
            btnAddGrade = new Button();
            btnCancel = new Button();
            btnDeleteGrade = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // lbStudentsInfo
            // 
            lbStudentsInfo.AutoSize = true;
            lbStudentsInfo.Font = new Font("Segoe UI", 14F);
            lbStudentsInfo.Location = new Point(12, 9);
            lbStudentsInfo.Name = "lbStudentsInfo";
            lbStudentsInfo.Size = new Size(63, 25);
            lbStudentsInfo.TabIndex = 1;
            lbStudentsInfo.Text = "label1";
            // 
            // dgvGrades
            // 
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.AllowUserToDeleteRows = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(12, 56);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(955, 345);
            dgvGrades.TabIndex = 9;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Location = new Point(12, 421);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(161, 34);
            btnAddGrade.TabIndex = 10;
            btnAddGrade.Text = "Dodaj ocenę";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(806, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDeleteGrade
            // 
            btnDeleteGrade.Location = new Point(179, 421);
            btnDeleteGrade.Name = "btnDeleteGrade";
            btnDeleteGrade.Size = new Size(161, 34);
            btnDeleteGrade.TabIndex = 14;
            btnDeleteGrade.Text = "Usuń ocenę";
            btnDeleteGrade.UseVisualStyleBackColor = true;
            btnDeleteGrade.Click += btnDeleteGrade_Click;
            // 
            // FormEditStudentsGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 467);
            Controls.Add(btnDeleteGrade);
            Controls.Add(btnCancel);
            Controls.Add(btnAddGrade);
            Controls.Add(dgvGrades);
            Controls.Add(lbStudentsInfo);
            Name = "FormEditStudentsGrades";
            Text = "Edytuj oceny studenta";
            Load += FormEditStudentsGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbStudentsInfo;
        private DataGridView dgvGrades;
        private Button btnAddGrade;
        private Button btnCancel;
        private Button btnDeleteGrade;
    }
}