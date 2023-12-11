namespace ListManagement
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
            label1 = new Label();
            listBox1 = new ListBox();
            cbUppercase = new CheckBox();
            AddToListBtn = new Button();
            rbBananas = new RadioButton();
            rbApples = new RadioButton();
            rbOranges = new RadioButton();
            comboBox1 = new ComboBox();
            listClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Choose a color:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(480, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 356);
            listBox1.TabIndex = 1;
            // 
            // cbUppercase
            // 
            cbUppercase.AutoSize = true;
            cbUppercase.Location = new Point(259, 105);
            cbUppercase.Name = "cbUppercase";
            cbUppercase.Size = new Size(201, 36);
            cbUppercase.TabIndex = 2;
            cbUppercase.Text = "To UPPERCASE";
            cbUppercase.UseVisualStyleBackColor = true;
            // 
            // AddToListBtn
            // 
            AddToListBtn.Location = new Point(12, 171);
            AddToListBtn.Name = "AddToListBtn";
            AddToListBtn.Size = new Size(448, 53);
            AddToListBtn.TabIndex = 3;
            AddToListBtn.Text = "Add To List";
            AddToListBtn.UseVisualStyleBackColor = true;
            AddToListBtn.Click += AddToListBtn_Click;
            // 
            // rbBananas
            // 
            rbBananas.AutoSize = true;
            rbBananas.Location = new Point(153, 337);
            rbBananas.Name = "rbBananas";
            rbBananas.Size = new Size(133, 36);
            rbBananas.TabIndex = 4;
            rbBananas.TabStop = true;
            rbBananas.Text = "Bananas";
            rbBananas.UseVisualStyleBackColor = true;
            rbBananas.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbApples
            // 
            rbApples.AutoSize = true;
            rbApples.Location = new Point(12, 337);
            rbApples.Name = "rbApples";
            rbApples.Size = new Size(117, 36);
            rbApples.TabIndex = 5;
            rbApples.TabStop = true;
            rbApples.Text = "Apples";
            rbApples.UseVisualStyleBackColor = true;
            rbApples.CheckedChanged += rbApples_CheckedChanged;
            // 
            // rbOranges
            // 
            rbOranges.AutoSize = true;
            rbOranges.Location = new Point(326, 337);
            rbOranges.Name = "rbOranges";
            rbOranges.Size = new Size(134, 36);
            rbOranges.TabIndex = 6;
            rbOranges.TabStop = true;
            rbOranges.Text = "Oranges";
            rbOranges.UseVisualStyleBackColor = true;
            rbOranges.CheckedChanged += rbOranges_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "green", "blue", "red", "black" });
            comboBox1.Location = new Point(259, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 40);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listClear
            // 
            listClear.Location = new Point(480, 391);
            listClear.Name = "listClear";
            listClear.Size = new Size(308, 47);
            listClear.TabIndex = 8;
            listClear.Text = "Clear List";
            listClear.UseVisualStyleBackColor = true;
            listClear.Click += listClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listClear);
            Controls.Add(comboBox1);
            Controls.Add(rbOranges);
            Controls.Add(rbApples);
            Controls.Add(rbBananas);
            Controls.Add(AddToListBtn);
            Controls.Add(cbUppercase);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private CheckBox cbUppercase;
        private Button AddToListBtn;
        private RadioButton rbBananas;
        private RadioButton rbApples;
        private RadioButton rbOranges;
        private ComboBox comboBox1;
        private Button listClear;
    }
}