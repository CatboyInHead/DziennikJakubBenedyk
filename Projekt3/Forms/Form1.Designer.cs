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
            tpGroups = new TabPage();
            btnGradesDiagram = new Button();
            btnAssignSubject = new Button();
            btnAddGroup = new Button();
            dgvGroups = new DataGridView();
            tpStudents = new TabPage();
            btnEditStudentGrades = new Button();
            btnAddStudent = new Button();
            dgvStudents = new DataGridView();
            tpSubjects = new TabPage();
            btnAddSubject = new Button();
            dgvSubjects = new DataGridView();
            tpSearch = new TabPage();
            dgvSearchList = new DataGridView();
            btnSearch = new Button();
            label2 = new Label();
            label1 = new Label();
            tbStudentsID = new TextBox();
            tbNameAndLastName = new TextBox();
            btnEditGroupGrades = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudyFields).BeginInit();
            tabControl1.SuspendLayout();
            tpFields.SuspendLayout();
            tpGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            tpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tpSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchList).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudyField
            // 
            btnAddStudyField.Location = new Point(5, 351);
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
            dgvStudyFields.Location = new Point(0, 0);
            dgvStudyFields.Name = "dgvStudyFields";
            dgvStudyFields.ReadOnly = true;
            dgvStudyFields.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudyFields.Size = new Size(955, 345);
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(963, 419);
            tabControl1.TabIndex = 9;
            // 
            // tpFields
            // 
            tpFields.Controls.Add(dgvStudyFields);
            tpFields.Controls.Add(btnAddStudyField);
            tpFields.Location = new Point(4, 24);
            tpFields.Name = "tpFields";
            tpFields.Padding = new Padding(3);
            tpFields.Size = new Size(955, 391);
            tpFields.TabIndex = 0;
            tpFields.Text = "Kierunki";
            tpFields.UseVisualStyleBackColor = true;
            // 
            // tpGroups
            // 
            tpGroups.Controls.Add(btnEditGroupGrades);
            tpGroups.Controls.Add(btnGradesDiagram);
            tpGroups.Controls.Add(btnAssignSubject);
            tpGroups.Controls.Add(btnAddGroup);
            tpGroups.Controls.Add(dgvGroups);
            tpGroups.Location = new Point(4, 24);
            tpGroups.Name = "tpGroups";
            tpGroups.Padding = new Padding(3);
            tpGroups.Size = new Size(955, 391);
            tpGroups.TabIndex = 1;
            tpGroups.Text = "Grupy";
            tpGroups.UseVisualStyleBackColor = true;
            // 
            // btnGradesDiagram
            // 
            btnGradesDiagram.Location = new Point(340, 351);
            btnGradesDiagram.Name = "btnGradesDiagram";
            btnGradesDiagram.Size = new Size(161, 34);
            btnGradesDiagram.TabIndex = 12;
            btnGradesDiagram.Text = "Wykres ocen";
            btnGradesDiagram.UseVisualStyleBackColor = true;
            btnGradesDiagram.Click += btnGradesDiagram_Click;
            // 
            // btnAssignSubject
            // 
            btnAssignSubject.Location = new Point(173, 351);
            btnAssignSubject.Name = "btnAssignSubject";
            btnAssignSubject.Size = new Size(161, 34);
            btnAssignSubject.TabIndex = 11;
            btnAssignSubject.Text = "Przypisz przedmiot";
            btnAssignSubject.UseVisualStyleBackColor = true;
            btnAssignSubject.Click += btnAssignSubject_Click;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(6, 351);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(161, 34);
            btnAddGroup.TabIndex = 10;
            btnAddGroup.Text = "Dodaj grupę";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // dgvGroups
            // 
            dgvGroups.AllowUserToAddRows = false;
            dgvGroups.AllowUserToDeleteRows = false;
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Location = new Point(0, 0);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.ReadOnly = true;
            dgvGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroups.Size = new Size(955, 345);
            dgvGroups.TabIndex = 9;
            dgvGroups.CellDoubleClick += dgvGroups_CellDoubleClick;
            // 
            // tpStudents
            // 
            tpStudents.Controls.Add(btnEditStudentGrades);
            tpStudents.Controls.Add(btnAddStudent);
            tpStudents.Controls.Add(dgvStudents);
            tpStudents.Location = new Point(4, 24);
            tpStudents.Name = "tpStudents";
            tpStudents.Padding = new Padding(3);
            tpStudents.Size = new Size(955, 391);
            tpStudents.TabIndex = 2;
            tpStudents.Text = "Studenci";
            tpStudents.UseVisualStyleBackColor = true;
            // 
            // btnEditStudentGrades
            // 
            btnEditStudentGrades.Location = new Point(173, 351);
            btnEditStudentGrades.Name = "btnEditStudentGrades";
            btnEditStudentGrades.Size = new Size(161, 34);
            btnEditStudentGrades.TabIndex = 12;
            btnEditStudentGrades.Text = "Edytuj oceny studenta";
            btnEditStudentGrades.UseVisualStyleBackColor = true;
            btnEditStudentGrades.Click += btnEditStudentGrades_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(6, 351);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(161, 34);
            btnAddStudent.TabIndex = 11;
            btnAddStudent.Text = "Dodaj studenta";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(0, 0);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(955, 345);
            dgvStudents.TabIndex = 10;
            dgvStudents.CellContentClick += dvgStudents_CellDoubleClick;
            // 
            // tpSubjects
            // 
            tpSubjects.Controls.Add(btnAddSubject);
            tpSubjects.Controls.Add(dgvSubjects);
            tpSubjects.Location = new Point(4, 24);
            tpSubjects.Name = "tpSubjects";
            tpSubjects.Padding = new Padding(3);
            tpSubjects.Size = new Size(955, 391);
            tpSubjects.TabIndex = 3;
            tpSubjects.Text = "Przedmioty";
            tpSubjects.UseVisualStyleBackColor = true;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(6, 351);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(161, 34);
            btnAddSubject.TabIndex = 12;
            btnAddSubject.Text = "Dodaj przedmiot";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(0, 0);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjects.Size = new Size(955, 345);
            dgvSubjects.TabIndex = 11;
            // 
            // tpSearch
            // 
            tpSearch.Controls.Add(dgvSearchList);
            tpSearch.Controls.Add(btnSearch);
            tpSearch.Controls.Add(label2);
            tpSearch.Controls.Add(label1);
            tpSearch.Controls.Add(tbStudentsID);
            tpSearch.Controls.Add(tbNameAndLastName);
            tpSearch.Location = new Point(4, 24);
            tpSearch.Name = "tpSearch";
            tpSearch.Padding = new Padding(3);
            tpSearch.Size = new Size(955, 391);
            tpSearch.TabIndex = 4;
            tpSearch.Text = "Wyszukiwarka";
            tpSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSearchList
            // 
            dgvSearchList.AllowUserToAddRows = false;
            dgvSearchList.AllowUserToDeleteRows = false;
            dgvSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchList.Location = new Point(273, 0);
            dgvSearchList.Name = "dgvSearchList";
            dgvSearchList.ReadOnly = true;
            dgvSearchList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchList.Size = new Size(682, 391);
            dgvSearchList.TabIndex = 14;
            dgvSearchList.CellDoubleClick += dvgSearchList_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(38, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 34);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Wyszukaj";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(38, 55);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Numer indmeksu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Imię i nazwisko";
            // 
            // tbStudentsID
            // 
            tbStudentsID.Location = new Point(167, 56);
            tbStudentsID.Name = "tbStudentsID";
            tbStudentsID.Size = new Size(100, 23);
            tbStudentsID.TabIndex = 1;
            // 
            // tbNameAndLastName
            // 
            tbNameAndLastName.Location = new Point(167, 27);
            tbNameAndLastName.Name = "tbNameAndLastName";
            tbNameAndLastName.Size = new Size(100, 23);
            tbNameAndLastName.TabIndex = 0;
            // 
            // btnEditGroupGrades
            // 
            btnEditGroupGrades.Location = new Point(507, 351);
            btnEditGroupGrades.Name = "btnEditGroupGrades";
            btnEditGroupGrades.Size = new Size(161, 34);
            btnEditGroupGrades.TabIndex = 13;
            btnEditGroupGrades.Text = "Edytuj oceny grupy";
            btnEditGroupGrades.UseVisualStyleBackColor = true;
            btnEditGroupGrades.Click += btnEditGroupGrades_Click;
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
            tpGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            tpStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tpSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            tpSearch.ResumeLayout(false);
            tpSearch.PerformLayout();
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
        private TextBox tbNameAndLastName;
        private DataGridView dgvSearchList;
        private Button btnSearch;
        private Label label2;
        private Label label1;
        private TextBox tbStudentsID;
        private Button btnGradesDiagram;
        private Button btnEditGroupGrades;
    }
}
