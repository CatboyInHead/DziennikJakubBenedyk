namespace Projekt3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddStudyField = new Button();
            dgvStudyFields = new DataGridView();
            tabControl1 = new TabControl();
            tpFields = new TabPage();
            panel1 = new Panel();
            tpGroups = new TabPage();
            panel2 = new Panel();
            button1 = new Button();
            btnEditGroupGrades = new Button();
            btnAddGroup = new Button();
            btnGradesDiagram = new Button();
            btnAssignSubject = new Button();
            dgvGroups = new DataGridView();
            tpStudents = new TabPage();
            panel3 = new Panel();
            button2 = new Button();
            btnRemoveStudent = new Button();
            button3 = new Button();
            btnEditStudentGrades = new Button();
            btnAddStudent = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dgvStudents = new DataGridView();
            tpSubjects = new TabPage();
            panel4 = new Panel();
            button7 = new Button();
            btnAddSubject = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            dgvSubjects = new DataGridView();
            tpSearch = new TabPage();
            panel5 = new Panel();
            label1 = new Label();
            tbNameAndLastName = new TextBox();
            btnSearch = new Button();
            tbStudentsID = new TextBox();
            label2 = new Label();
            dgvSearchList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudyFields).BeginInit();
            tabControl1.SuspendLayout();
            tpFields.SuspendLayout();
            panel1.SuspendLayout();
            tpGroups.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            tpStudents.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tpSubjects.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            tpSearch.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchList).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudyField
            // 
            btnAddStudyField.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddStudyField.Location = new Point(6, 8);
            btnAddStudyField.Name = "btnAddStudyField";
            btnAddStudyField.Size = new Size(161, 34);
            btnAddStudyField.TabIndex = 2;
            btnAddStudyField.Text = "Dodaj kierunek studiów";
            btnAddStudyField.UseVisualStyleBackColor = true;
            btnAddStudyField.Click += btnAddStudyField_Click;
            // 
            // dgvStudyFields
            // 
            dgvStudyFields.AllowUserToAddRows = false;
            dgvStudyFields.AllowUserToDeleteRows = false;
            dgvStudyFields.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudyFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudyFields.Dock = DockStyle.Fill;
            dgvStudyFields.Location = new Point(3, 3);
            dgvStudyFields.Name = "dgvStudyFields";
            dgvStudyFields.ReadOnly = true;
            dgvStudyFields.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudyFields.Size = new Size(962, 433);
            dgvStudyFields.TabIndex = 8;
            dgvStudyFields.CellDoubleClick += dgvStudyFields_CellDoubleClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpFields);
            tabControl1.Controls.Add(tpGroups);
            tabControl1.Controls.Add(tpStudents);
            tabControl1.Controls.Add(tpSubjects);
            tabControl1.Controls.Add(tpSearch);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(976, 467);
            tabControl1.TabIndex = 9;
            // 
            // tpFields
            // 
            tpFields.Controls.Add(panel1);
            tpFields.Controls.Add(dgvStudyFields);
            tpFields.Location = new Point(4, 24);
            tpFields.Name = "tpFields";
            tpFields.Padding = new Padding(3);
            tpFields.Size = new Size(968, 439);
            tpFields.TabIndex = 0;
            tpFields.Text = "Kierunki";
            tpFields.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddStudyField);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 48);
            panel1.TabIndex = 9;
            // 
            // tpGroups
            // 
            tpGroups.Controls.Add(panel2);
            tpGroups.Controls.Add(dgvGroups);
            tpGroups.Location = new Point(4, 24);
            tpGroups.Name = "tpGroups";
            tpGroups.Padding = new Padding(3);
            tpGroups.Size = new Size(968, 439);
            tpGroups.TabIndex = 1;
            tpGroups.Text = "Grupy";
            tpGroups.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnEditGroupGrades);
            panel2.Controls.Add(btnAddGroup);
            panel2.Controls.Add(btnGradesDiagram);
            panel2.Controls.Add(btnAssignSubject);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 48);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(6, -44);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 2;
            button1.Text = "Dodaj kierunek studiów";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEditGroupGrades
            // 
            btnEditGroupGrades.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditGroupGrades.Location = new Point(507, 11);
            btnEditGroupGrades.Name = "btnEditGroupGrades";
            btnEditGroupGrades.Size = new Size(161, 34);
            btnEditGroupGrades.TabIndex = 13;
            btnEditGroupGrades.Text = "Wyświetl oceny grupy";
            btnEditGroupGrades.UseVisualStyleBackColor = true;
            btnEditGroupGrades.Click += btnEditGroupGrades_Click;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddGroup.Location = new Point(6, 11);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(161, 34);
            btnAddGroup.TabIndex = 10;
            btnAddGroup.Text = "Dodaj grupę";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // btnGradesDiagram
            // 
            btnGradesDiagram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGradesDiagram.Location = new Point(340, 11);
            btnGradesDiagram.Name = "btnGradesDiagram";
            btnGradesDiagram.Size = new Size(161, 34);
            btnGradesDiagram.TabIndex = 12;
            btnGradesDiagram.Text = "Wykres ocen";
            btnGradesDiagram.UseVisualStyleBackColor = true;
            btnGradesDiagram.Click += btnGradesDiagram_Click;
            // 
            // btnAssignSubject
            // 
            btnAssignSubject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAssignSubject.Location = new Point(173, 11);
            btnAssignSubject.Name = "btnAssignSubject";
            btnAssignSubject.Size = new Size(161, 34);
            btnAssignSubject.TabIndex = 11;
            btnAssignSubject.Text = "Przypisz przedmiot";
            btnAssignSubject.UseVisualStyleBackColor = true;
            btnAssignSubject.Click += btnAssignSubject_Click;
            // 
            // dgvGroups
            // 
            dgvGroups.AllowUserToAddRows = false;
            dgvGroups.AllowUserToDeleteRows = false;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Dock = DockStyle.Fill;
            dgvGroups.Location = new Point(3, 3);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.ReadOnly = true;
            dgvGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroups.Size = new Size(962, 433);
            dgvGroups.TabIndex = 9;
            dgvGroups.CellDoubleClick += dgvGroups_CellDoubleClick;
            // 
            // tpStudents
            // 
            tpStudents.Controls.Add(panel3);
            tpStudents.Controls.Add(dgvStudents);
            tpStudents.Location = new Point(4, 24);
            tpStudents.Name = "tpStudents";
            tpStudents.Padding = new Padding(3);
            tpStudents.Size = new Size(968, 439);
            tpStudents.TabIndex = 2;
            tpStudents.Text = "Studenci";
            tpStudents.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnRemoveStudent);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnEditStudentGrades);
            panel3.Controls.Add(btnAddStudent);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 388);
            panel3.Name = "panel3";
            panel3.Size = new Size(962, 48);
            panel3.TabIndex = 15;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(6, -96);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 2;
            button2.Text = "Dodaj kierunek studiów";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(170, 11);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(161, 34);
            btnRemoveStudent.TabIndex = 13;
            btnRemoveStudent.Text = "Usuń studenta";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(507, -41);
            button3.Name = "button3";
            button3.Size = new Size(161, 34);
            button3.TabIndex = 13;
            button3.Text = "Wyświetl oceny grupy";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEditStudentGrades
            // 
            btnEditStudentGrades.Location = new Point(337, 11);
            btnEditStudentGrades.Name = "btnEditStudentGrades";
            btnEditStudentGrades.Size = new Size(161, 34);
            btnEditStudentGrades.TabIndex = 12;
            btnEditStudentGrades.Text = "Edytuj oceny studenta";
            btnEditStudentGrades.UseVisualStyleBackColor = true;
            btnEditStudentGrades.Click += btnEditStudentGrades_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(3, 11);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(161, 34);
            btnAddStudent.TabIndex = 11;
            btnAddStudent.Text = "Dodaj studenta";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(6, -41);
            button4.Name = "button4";
            button4.Size = new Size(161, 34);
            button4.TabIndex = 10;
            button4.Text = "Dodaj grupę";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(340, -41);
            button5.Name = "button5";
            button5.Size = new Size(161, 34);
            button5.TabIndex = 12;
            button5.Text = "Wykres ocen";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.Location = new Point(173, -41);
            button6.Name = "button6";
            button6.Size = new Size(161, 34);
            button6.TabIndex = 11;
            button6.Text = "Przypisz przedmiot";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(3, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(962, 433);
            dgvStudents.TabIndex = 10;
            dgvStudents.CellContentClick += dvgStudents_CellDoubleClick;
            // 
            // tpSubjects
            // 
            tpSubjects.Controls.Add(panel4);
            tpSubjects.Controls.Add(dgvSubjects);
            tpSubjects.Location = new Point(4, 24);
            tpSubjects.Name = "tpSubjects";
            tpSubjects.Padding = new Padding(3);
            tpSubjects.Size = new Size(968, 439);
            tpSubjects.TabIndex = 3;
            tpSubjects.Text = "Przedmioty";
            tpSubjects.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(btnAddSubject);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button11);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 388);
            panel4.Name = "panel4";
            panel4.Size = new Size(962, 48);
            panel4.TabIndex = 15;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.Location = new Point(6, -96);
            button7.Name = "button7";
            button7.Size = new Size(161, 34);
            button7.TabIndex = 2;
            button7.Text = "Dodaj kierunek studiów";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(6, 8);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(161, 34);
            btnAddSubject.TabIndex = 12;
            btnAddSubject.Text = "Dodaj przedmiot";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button8.Location = new Point(507, -41);
            button8.Name = "button8";
            button8.Size = new Size(161, 34);
            button8.TabIndex = 13;
            button8.Text = "Wyświetl oceny grupy";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.Location = new Point(6, -41);
            button9.Name = "button9";
            button9.Size = new Size(161, 34);
            button9.TabIndex = 10;
            button9.Text = "Dodaj grupę";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button10.Location = new Point(340, -41);
            button10.Name = "button10";
            button10.Size = new Size(161, 34);
            button10.TabIndex = 12;
            button10.Text = "Wykres ocen";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.Location = new Point(173, -41);
            button11.Name = "button11";
            button11.Size = new Size(161, 34);
            button11.TabIndex = 11;
            button11.Text = "Przypisz przedmiot";
            button11.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Dock = DockStyle.Fill;
            dgvSubjects.Location = new Point(3, 3);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.Size = new Size(962, 433);
            dgvSubjects.TabIndex = 11;
            // 
            // tpSearch
            // 
            tpSearch.Controls.Add(panel5);
            tpSearch.Controls.Add(dgvSearchList);
            tpSearch.Location = new Point(4, 24);
            tpSearch.Name = "tpSearch";
            tpSearch.Padding = new Padding(3);
            tpSearch.Size = new Size(968, 439);
            tpSearch.TabIndex = 4;
            tpSearch.Text = "Wyszukiwarka";
            tpSearch.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(tbNameAndLastName);
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(tbStudentsID);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 433);
            panel5.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Imię i nazwisko";
            // 
            // tbNameAndLastName
            // 
            tbNameAndLastName.Location = new Point(147, 24);
            tbNameAndLastName.Name = "tbNameAndLastName";
            tbNameAndLastName.Size = new Size(100, 23);
            tbNameAndLastName.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(20, 97);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 34);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Wyszukaj";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbStudentsID
            // 
            tbStudentsID.Location = new Point(147, 53);
            tbStudentsID.Name = "tbStudentsID";
            tbStudentsID.Size = new Size(100, 23);
            tbStudentsID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(20, 56);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Numer indmeksu";
            // 
            // dgvSearchList
            // 
            dgvSearchList.AllowUserToAddRows = false;
            dgvSearchList.AllowUserToDeleteRows = false;
            dgvSearchList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchList.Location = new Point(282, 3);
            dgvSearchList.Name = "dgvSearchList";
            dgvSearchList.ReadOnly = true;
            dgvSearchList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchList.Size = new Size(670, 425);
            dgvSearchList.TabIndex = 14;
            dgvSearchList.CellDoubleClick += dvgSearchList_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 467);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Dziennik";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudyFields).EndInit();
            tabControl1.ResumeLayout(false);
            tpFields.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tpGroups.ResumeLayout(false);
            tpGroups.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            tpStudents.ResumeLayout(false);
            tpStudents.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tpSubjects.ResumeLayout(false);
            tpSubjects.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            tpSearch.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox addFieldTB;
        private Button btnAddStudyField;
        private DataGridView dgvStudyFields;
        private TabControl tabControl1;
        private TabPage tpFields;
        private TabPage tpGroups;
        private TabPage tpStudents;
        private Button btnAddGroup;
        private DataGridView dgvGroups;
        private Button btnAddStudent;
        private DataGridView dgvStudents;
        private Button btnEditStudentGrades;
        private TabPage tpSubjects;
        private DataGridView dgvSubjects;
        private Button btnAssignSubject;
        private Button btnAddSubject;
        private TabPage tpSearch;
        private DataGridView dgvSearchList;
        private Button btnGradesDiagram;
        private Button btnEditGroupGrades;
        private Button btnRemoveStudent;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Panel panel5;
        private Label label1;
        private TextBox tbNameAndLastName;
        private Button btnSearch;
        private TextBox tbStudentsID;
        private Label label2;
    }
}
