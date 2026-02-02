namespace Projekt3
{
    partial class FormAddGroup
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
            tbGroupName = new TextBox();
            label2 = new Label();
            cmbSemester = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Nazwa grupy";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(179, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(48, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbGroupName
            // 
            tbGroupName.Location = new Point(154, 44);
            tbGroupName.Name = "tbGroupName";
            tbGroupName.Size = new Size(100, 23);
            tbGroupName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 93);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Semestr";
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbSemester.Location = new Point(154, 85);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(121, 23);
            cmbSemester.TabIndex = 11;
            // 
            // FormAddGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSemester);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbGroupName);
            Name = "FormAddGroup";
            Text = "Dodawanie grupy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbGroupName;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbSemester;
    }
}