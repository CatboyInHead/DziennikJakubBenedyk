namespace Projekt3
{
    partial class FormAddFieldOfStudy
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
            tbFieldName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbModeOfStudy = new ComboBox();
            SuspendLayout();
            // 
            // tbFieldName
            // 
            tbFieldName.Location = new Point(162, 38);
            tbFieldName.Name = "tbFieldName";
            tbFieldName.Size = new Size(100, 23);
            tbFieldName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(56, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(187, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Nazwa kierunku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Tryb studiów";
            // 
            // cmbModeOfStudy
            // 
            cmbModeOfStudy.FormattingEnabled = true;
            cmbModeOfStudy.Location = new Point(162, 75);
            cmbModeOfStudy.Name = "cmbModeOfStudy";
            cmbModeOfStudy.Size = new Size(100, 23);
            cmbModeOfStudy.TabIndex = 5;
            // 
            // FormAddFieldOfStudy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbModeOfStudy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbFieldName);
            Name = "FormAddFieldOfStudy";
            Text = "Dodawanie kierunku studiów";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFieldName;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private ComboBox cmbModeOfStudy;
    }
}