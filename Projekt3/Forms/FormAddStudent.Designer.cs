namespace Projekt3
{
    partial class FormAddStudent
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
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            tbName = new TextBox();
            label2 = new Label();
            tbSurname = new TextBox();
            label3 = new Label();
            tbStudentsID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 15;
            label1.Text = "Imie";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(147, 143);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 143);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(122, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 17;
            label2.Text = "Nazwisko";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(122, 56);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(100, 23);
            tbSurname.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 88);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 19;
            label3.Text = "Numer indeksu";
            // 
            // tbStudentsID
            // 
            tbStudentsID.Location = new Point(122, 85);
            tbStudentsID.Name = "tbStudentsID";
            tbStudentsID.Size = new Size(100, 23);
            tbStudentsID.TabIndex = 18;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tbStudentsID);
            Controls.Add(label2);
            Controls.Add(tbSurname);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbName);
            Name = "FormAddStudent";
            Text = "Dodawanie nowego studenta";
            Load += FormAddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbName;
        private Label label2;
        private TextBox tbSurname;
        private Label label3;
        private TextBox tbStudentsID;
    }
}