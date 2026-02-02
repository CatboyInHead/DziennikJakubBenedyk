namespace Projekt3.Forms
{
    partial class FormAssignSubject
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
            label2 = new Label();
            cmbSubjectName = new ComboBox();
            btnCancel = new Button();
            btnAssignSubject = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 19;
            label2.Text = "Przedmiot";
            // 
            // cmbSubjectName
            // 
            cmbSubjectName.FormattingEnabled = true;
            cmbSubjectName.Location = new Point(108, 69);
            cmbSubjectName.Name = "cmbSubjectName";
            cmbSubjectName.Size = new Size(121, 23);
            cmbSubjectName.TabIndex = 18;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 34);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAssignSubject
            // 
            btnAssignSubject.Location = new Point(12, 155);
            btnAssignSubject.Name = "btnAssignSubject";
            btnAssignSubject.Size = new Size(161, 34);
            btnAssignSubject.TabIndex = 20;
            btnAssignSubject.Text = "Przypisz przedmiot";
            btnAssignSubject.UseVisualStyleBackColor = true;
            btnAssignSubject.Click += btnAssignSubject_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // FormAssignSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 201);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAssignSubject);
            Controls.Add(label2);
            Controls.Add(cmbSubjectName);
            Name = "FormAssignSubject";
            Text = "Przypisywanie przedmiotu";
            Load += FormAssignSubject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbSubjectName;
        private Button btnCancel;
        private Button btnAssignSubject;
        private Label label1;
    }
}