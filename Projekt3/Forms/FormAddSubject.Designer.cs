namespace Projekt3.Forms
{
    partial class FormAddSubject
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
            tbECTS = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tbSubjectName = new TextBox();
            SuspendLayout();
            // 
            // tbECTS
            // 
            tbECTS.Location = new Point(177, 50);
            tbECTS.Name = "tbECTS";
            tbECTS.Size = new Size(128, 23);
            tbECTS.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = "Nazwa przedmiotu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(58, 49);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Punkty ECTS";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 125);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbSubjectName
            // 
            tbSubjectName.Location = new Point(177, 20);
            tbSubjectName.Name = "tbSubjectName";
            tbSubjectName.Size = new Size(128, 23);
            tbSubjectName.TabIndex = 16;
            // 
            // FormAddSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 160);
            Controls.Add(tbSubjectName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbECTS);
            Name = "FormAddSubject";
            Text = "Dodawanie przedmiotu";
            Load += FormAddSubject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbECTS;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbSubjectName;
    }
}