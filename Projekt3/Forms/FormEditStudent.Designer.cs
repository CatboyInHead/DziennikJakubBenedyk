namespace Projekt3.Forms
{
    partial class FormEditStudent
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
            tbName = new TextBox();
            tbSurname = new TextBox();
            tbStudentsID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstGrades = new ListBox();
            btnEditGrade = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(132, 39);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(132, 68);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(100, 23);
            tbSurname.TabIndex = 1;
            // 
            // tbStudentsID
            // 
            tbStudentsID.Location = new Point(132, 97);
            tbStudentsID.Name = "tbStudentsID";
            tbStudentsID.Size = new Size(100, 23);
            tbStudentsID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 5;
            label3.Text = "Numer indeksu";
            // 
            // lstGrades
            // 
            lstGrades.FormattingEnabled = true;
            lstGrades.ItemHeight = 15;
            lstGrades.Location = new Point(463, 12);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(325, 319);
            lstGrades.TabIndex = 6;
            // 
            // btnEditGrade
            // 
            btnEditGrade.Location = new Point(348, 12);
            btnEditGrade.Name = "btnEditGrade";
            btnEditGrade.Size = new Size(109, 32);
            btnEditGrade.TabIndex = 7;
            btnEditGrade.Text = "Edytuj ocenę";
            btnEditGrade.UseVisualStyleBackColor = true;
            btnEditGrade.Click += btnEditGrade_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(679, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 32);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnEditGrade);
            Controls.Add(lstGrades);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbStudentsID);
            Controls.Add(tbSurname);
            Controls.Add(tbName);
            Name = "FormEditStudent";
            Text = "FormEditStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbSurname;
        private TextBox tbStudentsID;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstGrades;
        private Button btnEditGrade;
        private Button btnSave;
        private Button btnCancel;
    }
}