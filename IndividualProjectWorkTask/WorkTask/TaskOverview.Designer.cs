namespace WorkTask
{
    partial class TaskOverview
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
            TasksOverviewLB = new ListBox();
            TaskNameTB = new TextBox();
            label1 = new Label();
            SearchBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            MarkTaskBtn = new Button();
            TaskStatusCB = new ComboBox();
            label4 = new Label();
            TaskStatusSearchCB = new ComboBox();
            TaskDepSearchCB = new ComboBox();
            TaskDeleteBtn = new Button();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(1319, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(151, 56);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // TasksOverviewLB
            // 
            TasksOverviewLB.FormattingEnabled = true;
            TasksOverviewLB.ItemHeight = 32;
            TasksOverviewLB.Location = new Point(12, 12);
            TasksOverviewLB.Name = "TasksOverviewLB";
            TasksOverviewLB.Size = new Size(1301, 484);
            TasksOverviewLB.TabIndex = 1;
            // 
            // TaskNameTB
            // 
            TaskNameTB.Location = new Point(162, 523);
            TaskNameTB.Name = "TaskNameTB";
            TaskNameTB.Size = new Size(468, 39);
            TaskNameTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 526);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 3;
            label1.Text = "Task name:";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(12, 658);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(618, 45);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 571);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 7;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 616);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 8;
            label3.Text = "Department:";
            // 
            // MarkTaskBtn
            // 
            MarkTaskBtn.Location = new Point(694, 607);
            MarkTaskBtn.Name = "MarkTaskBtn";
            MarkTaskBtn.Size = new Size(619, 46);
            MarkTaskBtn.TabIndex = 9;
            MarkTaskBtn.Text = "Mark task";
            MarkTaskBtn.UseVisualStyleBackColor = true;
            MarkTaskBtn.Click += MarkTaskBtn_Click;
            // 
            // TaskStatusCB
            // 
            TaskStatusCB.FormattingEnabled = true;
            TaskStatusCB.Items.AddRange(new object[] { "Open", "In Progress", "Completed", "Blocked", "Cancelled" });
            TaskStatusCB.Location = new Point(874, 558);
            TaskStatusCB.Name = "TaskStatusCB";
            TaskStatusCB.Size = new Size(328, 40);
            TaskStatusCB.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(694, 561);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 16;
            label4.Text = "Status:";
            // 
            // TaskStatusSearchCB
            // 
            TaskStatusSearchCB.FormattingEnabled = true;
            TaskStatusSearchCB.Items.AddRange(new object[] { "Open", "In Progress", "Completed", "Blocked", "Cancelled" });
            TaskStatusSearchCB.Location = new Point(162, 568);
            TaskStatusSearchCB.Name = "TaskStatusSearchCB";
            TaskStatusSearchCB.Size = new Size(468, 40);
            TaskStatusSearchCB.TabIndex = 17;
            // 
            // TaskDepSearchCB
            // 
            TaskDepSearchCB.FormattingEnabled = true;
            TaskDepSearchCB.Items.AddRange(new object[] { "HumanResources", "ResearchAndDevelopment", "Support", "Marketing", "Sales" });
            TaskDepSearchCB.Location = new Point(162, 613);
            TaskDepSearchCB.Name = "TaskDepSearchCB";
            TaskDepSearchCB.Size = new Size(468, 40);
            TaskDepSearchCB.TabIndex = 18;
            // 
            // TaskDeleteBtn
            // 
            TaskDeleteBtn.Location = new Point(694, 658);
            TaskDeleteBtn.Name = "TaskDeleteBtn";
            TaskDeleteBtn.Size = new Size(619, 45);
            TaskDeleteBtn.TabIndex = 19;
            TaskDeleteBtn.Text = "Delete task";
            TaskDeleteBtn.UseVisualStyleBackColor = true;
            TaskDeleteBtn.Click += TaskDeleteBtn_Click;
            // 
            // TaskOverview
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 729);
            Controls.Add(TaskDeleteBtn);
            Controls.Add(TaskDepSearchCB);
            Controls.Add(TaskStatusSearchCB);
            Controls.Add(label4);
            Controls.Add(TaskStatusCB);
            Controls.Add(MarkTaskBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SearchBtn);
            Controls.Add(label1);
            Controls.Add(TaskNameTB);
            Controls.Add(TasksOverviewLB);
            Controls.Add(BackBtn);
            Name = "TaskOverview";
            Text = "TaskOverview";
            FormClosed += TaskOverview_FormClosed;
            Load += TaskOverview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private ListBox TasksOverviewLB;
        private TextBox TaskNameTB;
        private Label label1;
        private Button SearchBtn;
        private Label label2;
        private Label label3;
        private Button MarkTaskBtn;
        private ComboBox TaskStatusCB;
        private Label label4;
        private ComboBox TaskStatusSearchCB;
        private ComboBox TaskDepSearchCB;
        private Button TaskDeleteBtn;
    }
}