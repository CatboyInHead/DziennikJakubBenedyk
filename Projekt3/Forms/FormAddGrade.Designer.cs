namespace Projekt3.Forms
{
    partial class FormAddGrade
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
            btnAddGrade = new Button();
            btnCancel = new Button();
            cmbGrade = new ComboBox();
            lbstudentsInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbSubject = new ComboBox();
            rtbDescription = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAddGrade
            // 
            btnAddGrade.Location = new Point(12, 404);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(161, 34);
            btnAddGrade.TabIndex = 11;
            btnAddGrade.Text = "Dodaj ocenę";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(217, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbGrade
            // 
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Items.AddRange(new object[] { "2", "3", "3,5", "4", "4,5", "5" });
            cmbGrade.Location = new Point(111, 66);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(121, 23);
            cmbGrade.TabIndex = 13;
            // 
            // lbstudentsInfo
            // 
            lbstudentsInfo.AutoSize = true;
            lbstudentsInfo.Font = new Font("Segoe UI", 14F);
            lbstudentsInfo.Location = new Point(12, 9);
            lbstudentsInfo.Name = "lbstudentsInfo";
            lbstudentsInfo.Size = new Size(63, 25);
            lbstudentsInfo.TabIndex = 14;
            lbstudentsInfo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(25, 65);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 15;
            label1.Text = "Ocena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 17;
            label2.Text = "Przedmiot";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(111, 95);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 16;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(111, 124);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(121, 96);
            rtbDescription.TabIndex = 19;
            rtbDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 20;
            label3.Text = "Opis";
            // 
            // FormAddGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(rtbDescription);
            Controls.Add(label2);
            Controls.Add(cmbSubject);
            Controls.Add(label1);
            Controls.Add(lbstudentsInfo);
            Controls.Add(cmbGrade);
            Controls.Add(btnCancel);
            Controls.Add(btnAddGrade);
            Name = "FormAddGrade";
            Text = "Dodawanie oceny";
            Load += FormAddGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddGrade;
        private Button btnCancel;
        private ComboBox cmbGrade;
        private Label lbstudentsInfo;
        private Label label1;
        private Label label2;
        private ComboBox cmbSubject;
        private RichTextBox rtbDescription;
        private Label label3;
    }
}