namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            courseObjectCreate = new Button();
            showInfo = new Button();
            label1 = new Label();
            label2 = new Label();
            courseInfo = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // courseObjectCreate
            // 
            courseObjectCreate.Location = new Point(91, 224);
            courseObjectCreate.Name = "courseObjectCreate";
            courseObjectCreate.Size = new Size(445, 53);
            courseObjectCreate.TabIndex = 2;
            courseObjectCreate.Text = "Create Course-Object";
            courseObjectCreate.UseVisualStyleBackColor = true;
            courseObjectCreate.Click += courseObjectCreate_Click;
            // 
            // showInfo
            // 
            showInfo.Location = new Point(91, 307);
            showInfo.Name = "showInfo";
            showInfo.Size = new Size(445, 55);
            showInfo.TabIndex = 3;
            showInfo.Text = "Show info of Course-Object";
            showInfo.UseVisualStyleBackColor = true;
            showInfo.Click += showInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 50);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 4;
            label1.Text = "Course name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 147);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 5;
            label2.Text = "Course ECs:";
            // 
            // courseInfo
            // 
            courseInfo.AutoSize = true;
            courseInfo.Location = new Point(26, 400);
            courseInfo.Name = "courseInfo";
            courseInfo.Size = new Size(78, 32);
            courseInfo.TabIndex = 6;
            courseInfo.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(courseInfo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showInfo);
            Controls.Add(courseObjectCreate);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button courseObjectCreate;
        private Button showInfo;
        private Label label1;
        private Label label2;
        private Label courseInfo;
    }
}