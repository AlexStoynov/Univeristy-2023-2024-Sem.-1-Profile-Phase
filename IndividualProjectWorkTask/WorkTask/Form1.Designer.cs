namespace WorkTask
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
            TaskCreationFormBtn = new Button();
            EmployeeCreationFormButtn = new Button();
            TaskOverviewFormBtn = new Button();
            AssignTaskFormBtn = new Button();
            SuspendLayout();
            // 
            // TaskCreationFormBtn
            // 
            TaskCreationFormBtn.Location = new Point(195, 112);
            TaskCreationFormBtn.Name = "TaskCreationFormBtn";
            TaskCreationFormBtn.Size = new Size(362, 70);
            TaskCreationFormBtn.TabIndex = 0;
            TaskCreationFormBtn.Text = "Task Creation";
            TaskCreationFormBtn.UseVisualStyleBackColor = true;
            TaskCreationFormBtn.Click += TaskCreationFormBtn_Click;
            // 
            // EmployeeCreationFormButtn
            // 
            EmployeeCreationFormButtn.Location = new Point(195, 197);
            EmployeeCreationFormButtn.Name = "EmployeeCreationFormButtn";
            EmployeeCreationFormButtn.Size = new Size(362, 70);
            EmployeeCreationFormButtn.TabIndex = 1;
            EmployeeCreationFormButtn.Text = "Employee Creation";
            EmployeeCreationFormButtn.UseVisualStyleBackColor = true;
            EmployeeCreationFormButtn.Click += EmployeeCreationFormButtn_Click;
            // 
            // TaskOverviewFormBtn
            // 
            TaskOverviewFormBtn.Location = new Point(195, 285);
            TaskOverviewFormBtn.Name = "TaskOverviewFormBtn";
            TaskOverviewFormBtn.Size = new Size(362, 70);
            TaskOverviewFormBtn.TabIndex = 2;
            TaskOverviewFormBtn.Text = "Task Overview";
            TaskOverviewFormBtn.UseVisualStyleBackColor = true;
            TaskOverviewFormBtn.Click += TaskOverviewFormBtn_Click;
            // 
            // AssignTaskFormBtn
            // 
            AssignTaskFormBtn.Location = new Point(195, 376);
            AssignTaskFormBtn.Name = "AssignTaskFormBtn";
            AssignTaskFormBtn.Size = new Size(362, 70);
            AssignTaskFormBtn.TabIndex = 3;
            AssignTaskFormBtn.Text = "Task Assigning";
            AssignTaskFormBtn.UseVisualStyleBackColor = true;
            AssignTaskFormBtn.Click += AssignTaskFormBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 558);
            Controls.Add(AssignTaskFormBtn);
            Controls.Add(TaskOverviewFormBtn);
            Controls.Add(EmployeeCreationFormButtn);
            Controls.Add(TaskCreationFormBtn);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button TaskCreationFormBtn;
        private Button EmployeeCreationFormButtn;
        private Button TaskOverviewFormBtn;
        private Button AssignTaskFormBtn;
    }
}