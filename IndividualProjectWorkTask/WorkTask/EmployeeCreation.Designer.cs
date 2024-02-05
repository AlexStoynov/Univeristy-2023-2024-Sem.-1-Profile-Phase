namespace WorkTask
{
    partial class EmployeeCreation
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
            BackBtn = new Button();
            FirstNameTB = new TextBox();
            LastNameTB = new TextBox();
            GenderTB = new TextBox();
            StreetNameTB = new TextBox();
            StreetNumTB = new TextBox();
            ZipCodeTB = new TextBox();
            CityTB = new TextBox();
            EmailTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DepartmentComboBox = new ComboBox();
            label9 = new Label();
            CreateEmployeeBtn = new Button();
            LoadEmployeesBtn = new Button();
            SaveEmployeesBtn = new Button();
            employeesTable = new DataGridView();
            EmployeeId = new DataGridViewTextBoxColumn();
            SSN = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            EmployeeSSN = new TextBox();
            label10 = new Label();
            RefreshTableBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)employeesTable).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(1069, 647);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 46);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Location = new Point(216, 33);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(242, 39);
            FirstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            LastNameTB.Location = new Point(216, 86);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(242, 39);
            LastNameTB.TabIndex = 2;
            // 
            // GenderTB
            // 
            GenderTB.Location = new Point(216, 139);
            GenderTB.Name = "GenderTB";
            GenderTB.Size = new Size(242, 39);
            GenderTB.TabIndex = 3;
            // 
            // StreetNameTB
            // 
            StreetNameTB.Location = new Point(216, 190);
            StreetNameTB.Name = "StreetNameTB";
            StreetNameTB.Size = new Size(242, 39);
            StreetNameTB.TabIndex = 4;
            // 
            // StreetNumTB
            // 
            StreetNumTB.Location = new Point(216, 241);
            StreetNumTB.Name = "StreetNumTB";
            StreetNumTB.Size = new Size(242, 39);
            StreetNumTB.TabIndex = 5;
            // 
            // ZipCodeTB
            // 
            ZipCodeTB.Location = new Point(216, 295);
            ZipCodeTB.Name = "ZipCodeTB";
            ZipCodeTB.Size = new Size(242, 39);
            ZipCodeTB.TabIndex = 6;
            // 
            // CityTB
            // 
            CityTB.Location = new Point(216, 354);
            CityTB.Name = "CityTB";
            CityTB.Size = new Size(242, 39);
            CityTB.TabIndex = 7;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(216, 404);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(242, 39);
            EmailTB.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 9;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 83);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 10;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 142);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 11;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 193);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 12;
            label4.Text = "Street name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 244);
            label5.Name = "label5";
            label5.Size = new Size(172, 32);
            label5.TabIndex = 13;
            label5.Text = "Street number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 298);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 14;
            label6.Text = "Zip code:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 357);
            label7.Name = "label7";
            label7.Size = new Size(60, 32);
            label7.TabIndex = 15;
            label7.Text = "City:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 407);
            label8.Name = "label8";
            label8.Size = new Size(86, 32);
            label8.TabIndex = 16;
            label8.Text = "E-mail:";
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Items.AddRange(new object[] { "HumanResources", "ResearchAndDevelopment", "Support", "Marketing", "Sales" });
            DepartmentComboBox.Location = new Point(216, 460);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(242, 40);
            DepartmentComboBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 463);
            label9.Name = "label9";
            label9.Size = new Size(147, 32);
            label9.TabIndex = 18;
            label9.Text = "Department:";
            // 
            // CreateEmployeeBtn
            // 
            CreateEmployeeBtn.Location = new Point(38, 617);
            CreateEmployeeBtn.Name = "CreateEmployeeBtn";
            CreateEmployeeBtn.Size = new Size(420, 46);
            CreateEmployeeBtn.TabIndex = 19;
            CreateEmployeeBtn.Text = "Create Employee";
            CreateEmployeeBtn.UseVisualStyleBackColor = true;
            CreateEmployeeBtn.Click += CreateEmployeeBtn_Click;
            // 
            // LoadEmployeesBtn
            // 
            LoadEmployeesBtn.Location = new Point(38, 721);
            LoadEmployeesBtn.Name = "LoadEmployeesBtn";
            LoadEmployeesBtn.Size = new Size(420, 46);
            LoadEmployeesBtn.TabIndex = 20;
            LoadEmployeesBtn.Text = "Load Employees";
            LoadEmployeesBtn.UseVisualStyleBackColor = true;
            LoadEmployeesBtn.Click += LoadEmployeesBtn_Click;
            // 
            // SaveEmployeesBtn
            // 
            SaveEmployeesBtn.Location = new Point(38, 669);
            SaveEmployeesBtn.Name = "SaveEmployeesBtn";
            SaveEmployeesBtn.Size = new Size(420, 46);
            SaveEmployeesBtn.TabIndex = 21;
            SaveEmployeesBtn.Text = "Save Employees";
            SaveEmployeesBtn.UseVisualStyleBackColor = true;
            SaveEmployeesBtn.Click += SaveEmployeesBtn_Click;
            // 
            // employeesTable
            // 
            employeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesTable.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, SSN, FirstName, LastName, Department });
            employeesTable.Location = new Point(500, 12);
            employeesTable.Name = "employeesTable";
            employeesTable.RowHeadersWidth = 82;
            employeesTable.RowTemplate.Height = 41;
            employeesTable.Size = new Size(710, 614);
            employeesTable.TabIndex = 22;
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "Id";
            EmployeeId.MinimumWidth = 10;
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Width = 200;
            // 
            // SSN
            // 
            SSN.HeaderText = "SSN";
            SSN.MinimumWidth = 10;
            SSN.Name = "SSN";
            SSN.Width = 200;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 10;
            FirstName.Name = "FirstName";
            FirstName.Width = 200;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 10;
            LastName.Name = "LastName";
            LastName.Width = 200;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.MinimumWidth = 10;
            Department.Name = "Department";
            Department.Width = 200;
            // 
            // EmployeeSSN
            // 
            EmployeeSSN.Location = new Point(216, 517);
            EmployeeSSN.Name = "EmployeeSSN";
            EmployeeSSN.Size = new Size(242, 39);
            EmployeeSSN.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 524);
            label10.Name = "label10";
            label10.Size = new Size(63, 32);
            label10.TabIndex = 24;
            label10.Text = "SSN:";
            // 
            // RefreshTableBtn
            // 
            RefreshTableBtn.Location = new Point(500, 647);
            RefreshTableBtn.Name = "RefreshTableBtn";
            RefreshTableBtn.Size = new Size(329, 46);
            RefreshTableBtn.TabIndex = 25;
            RefreshTableBtn.Text = "Refresh table";
            RefreshTableBtn.UseVisualStyleBackColor = true;
            RefreshTableBtn.Click += RefreshTableBtn_Click;
            // 
            // EmployeeCreation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 790);
            Controls.Add(RefreshTableBtn);
            Controls.Add(label10);
            Controls.Add(EmployeeSSN);
            Controls.Add(employeesTable);
            Controls.Add(SaveEmployeesBtn);
            Controls.Add(LoadEmployeesBtn);
            Controls.Add(CreateEmployeeBtn);
            Controls.Add(label9);
            Controls.Add(DepartmentComboBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmailTB);
            Controls.Add(CityTB);
            Controls.Add(ZipCodeTB);
            Controls.Add(StreetNumTB);
            Controls.Add(StreetNameTB);
            Controls.Add(GenderTB);
            Controls.Add(LastNameTB);
            Controls.Add(FirstNameTB);
            Controls.Add(BackBtn);
            Name = "EmployeeCreation";
            Text = "EmployeeCreation";
            FormClosed += EmployeeCreation_FormClosed;
            Load += EmployeeCreation_Load;
            ((System.ComponentModel.ISupportInitialize)employeesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private TextBox FirstNameTB;
        private TextBox LastNameTB;
        private TextBox GenderTB;
        private TextBox StreetNameTB;
        private TextBox StreetNumTB;
        private TextBox ZipCodeTB;
        private TextBox CityTB;
        private TextBox EmailTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox DepartmentComboBox;
        private Label label9;
        private Button CreateEmployeeBtn;
        private Button LoadEmployeesBtn;
        private Button SaveEmployeesBtn;
        private DataGridView employeesTable;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn SSN;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Department;
        private TextBox EmployeeSSN;
        private Label label10;
        private Button RefreshTableBtn;
    }
}