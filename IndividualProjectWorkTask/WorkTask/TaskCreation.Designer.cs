namespace WorkTask
{
    partial class TaskCreation
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
            TaskNameTB = new TextBox();
            TaskDescriptionTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BackBtn = new Button();
            CreateTaskBtn = new Button();
            TaskDeadlineDTP = new DateTimePicker();
            DepartmentsCBList = new CheckedListBox();
            SuspendLayout();
            // 
            // TaskNameTB
            // 
            TaskNameTB.Location = new Point(180, 6);
            TaskNameTB.Name = "TaskNameTB";
            TaskNameTB.Size = new Size(242, 39);
            TaskNameTB.TabIndex = 0;
            // 
            // TaskDescriptionTB
            // 
            TaskDescriptionTB.Location = new Point(12, 170);
            TaskDescriptionTB.Multiline = true;
            TaskDescriptionTB.Name = "TaskDescriptionTB";
            TaskDescriptionTB.Size = new Size(591, 325);
            TaskDescriptionTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 4;
            label1.Text = "Task name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 5;
            label2.Text = "Task deadline:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 6;
            label3.Text = "Task description:";
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(735, 6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 46);
            BackBtn.TabIndex = 11;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CreateTaskBtn
            // 
            CreateTaskBtn.Location = new Point(12, 725);
            CreateTaskBtn.Name = "CreateTaskBtn";
            CreateTaskBtn.Size = new Size(591, 59);
            CreateTaskBtn.TabIndex = 12;
            CreateTaskBtn.Text = "Create Task";
            CreateTaskBtn.UseVisualStyleBackColor = true;
            CreateTaskBtn.Click += CreateTaskBtn_Click;
            // 
            // TaskDeadlineDTP
            // 
            TaskDeadlineDTP.Location = new Point(180, 66);
            TaskDeadlineDTP.Name = "TaskDeadlineDTP";
            TaskDeadlineDTP.Size = new Size(400, 39);
            TaskDeadlineDTP.TabIndex = 13;
            // 
            // DepartmentsCBList
            // 
            DepartmentsCBList.FormattingEnabled = true;
            DepartmentsCBList.Items.AddRange(new object[] { "HumanResources", "Marketing", "Sales", "Support", "ResearchandDevelopment" });
            DepartmentsCBList.Location = new Point(12, 513);
            DepartmentsCBList.Name = "DepartmentsCBList";
            DepartmentsCBList.Size = new Size(591, 184);
            DepartmentsCBList.TabIndex = 14;
            // 
            // TaskCreation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 796);
            Controls.Add(DepartmentsCBList);
            Controls.Add(TaskDeadlineDTP);
            Controls.Add(CreateTaskBtn);
            Controls.Add(BackBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TaskDescriptionTB);
            Controls.Add(TaskNameTB);
            Name = "TaskCreation";
            Text = "TaskCreation";
            FormClosed += TaskCreation_FormClosed;
            Load += TaskCreation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskNameTB;
        private TextBox TaskDescriptionTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BackBtn;
        private Button CreateTaskBtn;
        private DateTimePicker TaskDeadlineDTP;
        private CheckedListBox DepartmentsCBList;
    }
}