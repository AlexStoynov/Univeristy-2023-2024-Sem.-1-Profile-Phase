namespace SerializingObjects
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddTripBtn = new Button();
            groupBox3 = new GroupBox();
            ShowInfoSelectedBtn = new Button();
            DeleteSelectedTripBtn = new Button();
            listBox1 = new ListBox();
            ShowAllBtn = new Button();
            textBox2 = new TextBox();
            SearchBtn = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddTripBtn);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 286);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Trip";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(ShowAllBtn);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(418, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(654, 534);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "My trips";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 39);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(122, 105);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 39);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(99, 166);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 39);
            numericUpDown2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 3;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 4;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 168);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 5;
            label3.Text = "Rating:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 107);
            label4.Name = "label4";
            label4.Size = new Size(50, 32);
            label4.TabIndex = 6;
            label4.Text = "KM";
            // 
            // AddTripBtn
            // 
            AddTripBtn.Location = new Point(6, 211);
            AddTripBtn.Name = "AddTripBtn";
            AddTripBtn.Size = new Size(360, 46);
            AddTripBtn.TabIndex = 2;
            AddTripBtn.Text = "Add";
            AddTripBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DeleteSelectedTripBtn);
            groupBox3.Controls.Add(ShowInfoSelectedBtn);
            groupBox3.Location = new Point(12, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 174);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selected Trip";
            // 
            // ShowInfoSelectedBtn
            // 
            ShowInfoSelectedBtn.Location = new Point(6, 38);
            ShowInfoSelectedBtn.Name = "ShowInfoSelectedBtn";
            ShowInfoSelectedBtn.Size = new Size(388, 46);
            ShowInfoSelectedBtn.TabIndex = 0;
            ShowInfoSelectedBtn.Text = "Show info of current selected trip";
            ShowInfoSelectedBtn.UseVisualStyleBackColor = true;
            ShowInfoSelectedBtn.Click += button1_Click;
            // 
            // DeleteSelectedTripBtn
            // 
            DeleteSelectedTripBtn.Location = new Point(6, 102);
            DeleteSelectedTripBtn.Name = "DeleteSelectedTripBtn";
            DeleteSelectedTripBtn.Size = new Size(388, 46);
            DeleteSelectedTripBtn.TabIndex = 1;
            DeleteSelectedTripBtn.Text = "Delete selected trip";
            DeleteSelectedTripBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(20, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(609, 292);
            listBox1.TabIndex = 0;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(20, 344);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(609, 46);
            ShowAllBtn.TabIndex = 1;
            ShowAllBtn.Text = "Show all";
            ShowAllBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 39);
            textBox2.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(479, 415);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(150, 46);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 425);
            label5.Name = "label5";
            label5.Size = new Size(44, 32);
            label5.TabIndex = 4;
            label5.Text = "To:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 563);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button AddTripBtn;
        private GroupBox groupBox3;
        private Button DeleteSelectedTripBtn;
        private Button ShowInfoSelectedBtn;
        private Button SearchBtn;
        private TextBox textBox2;
        private Button ShowAllBtn;
        private ListBox listBox1;
        private Label label5;
    }
}