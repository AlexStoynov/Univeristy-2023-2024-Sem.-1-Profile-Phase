namespace WorkTask
{
    partial class TaskAssignment
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
            TasksLB = new ListBox();
            EmployeesLB = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            AssignBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(1443, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(150, 46);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // TasksLB
            // 
            TasksLB.FormattingEnabled = true;
            TasksLB.ItemHeight = 32;
            TasksLB.Location = new Point(6, 38);
            TasksLB.Name = "TasksLB";
            TasksLB.Size = new Size(684, 740);
            TasksLB.TabIndex = 1;
            // 
            // EmployeesLB
            // 
            EmployeesLB.FormattingEnabled = true;
            EmployeesLB.ItemHeight = 32;
            EmployeesLB.Location = new Point(17, 38);
            EmployeesLB.Name = "EmployeesLB";
            EmployeesLB.Size = new Size(684, 740);
            EmployeesLB.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TasksLB);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 794);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tasks";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(EmployeesLB);
            groupBox2.Location = new Point(714, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(715, 794);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employees";
            // 
            // AssignBtn
            // 
            AssignBtn.Location = new Point(12, 812);
            AssignBtn.Name = "AssignBtn";
            AssignBtn.Size = new Size(1417, 57);
            AssignBtn.TabIndex = 5;
            AssignBtn.Text = "Assign employee to task";
            AssignBtn.UseVisualStyleBackColor = true;
            AssignBtn.Click += AssignBtn_Click;
            // 
            // TaskAssignment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 885);
            Controls.Add(AssignBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BackBtn);
            Name = "TaskAssignment";
            Text = "TaskAssignment";
            FormClosed += TaskAssignment_FormClosed;
            Load += TaskAssignment_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BackBtn;
        private ListBox TasksLB;
        private ListBox EmployeesLB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button AssignBtn;
    }
}