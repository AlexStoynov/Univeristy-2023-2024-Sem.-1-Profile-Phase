namespace CrazyRounding
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
            NumLbl = new Label();
            NumTextBox = new TextBox();
            ToWholeRb = new RadioButton();
            ToTenthRb = new RadioButton();
            ToOneHundredRb = new RadioButton();
            RoundBtn = new Button();
            ListBoxNums = new ListBox();
            SuspendLayout();
            // 
            // NumLbl
            // 
            NumLbl.AutoSize = true;
            NumLbl.Location = new Point(12, 18);
            NumLbl.Name = "NumLbl";
            NumLbl.Size = new Size(107, 32);
            NumLbl.TabIndex = 0;
            NumLbl.Text = "Number:";
            // 
            // NumTextBox
            // 
            NumTextBox.Location = new Point(125, 15);
            NumTextBox.Name = "NumTextBox";
            NumTextBox.Size = new Size(200, 39);
            NumTextBox.TabIndex = 1;
            // 
            // ToWholeRb
            // 
            ToWholeRb.AutoSize = true;
            ToWholeRb.Location = new Point(125, 77);
            ToWholeRb.Name = "ToWholeRb";
            ToWholeRb.Size = new Size(146, 36);
            ToWholeRb.TabIndex = 2;
            ToWholeRb.TabStop = true;
            ToWholeRb.Text = "To Whole";
            ToWholeRb.UseVisualStyleBackColor = true;
            // 
            // ToTenthRb
            // 
            ToTenthRb.AutoSize = true;
            ToTenthRb.Location = new Point(125, 119);
            ToTenthRb.Name = "ToTenthRb";
            ToTenthRb.Size = new Size(137, 36);
            ToTenthRb.TabIndex = 3;
            ToTenthRb.TabStop = true;
            ToTenthRb.Text = "To Tenth";
            ToTenthRb.UseVisualStyleBackColor = true;
            // 
            // ToOneHundredRb
            // 
            ToOneHundredRb.AutoSize = true;
            ToOneHundredRb.Location = new Point(125, 161);
            ToOneHundredRb.Name = "ToOneHundredRb";
            ToOneHundredRb.Size = new Size(179, 36);
            ToOneHundredRb.TabIndex = 4;
            ToOneHundredRb.TabStop = true;
            ToOneHundredRb.Text = "To Hundreth";
            ToOneHundredRb.UseVisualStyleBackColor = true;
            ToOneHundredRb.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // RoundBtn
            // 
            RoundBtn.Location = new Point(387, 15);
            RoundBtn.Name = "RoundBtn";
            RoundBtn.Size = new Size(226, 182);
            RoundBtn.TabIndex = 5;
            RoundBtn.Text = "Round 10x";
            RoundBtn.UseVisualStyleBackColor = true;
            RoundBtn.Click += RoundBtn_Click;
            // 
            // ListBoxNums
            // 
            ListBoxNums.FormattingEnabled = true;
            ListBoxNums.ItemHeight = 32;
            ListBoxNums.Location = new Point(12, 235);
            ListBoxNums.Name = "ListBoxNums";
            ListBoxNums.Size = new Size(601, 420);
            ListBoxNums.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 688);
            Controls.Add(ListBoxNums);
            Controls.Add(RoundBtn);
            Controls.Add(ToOneHundredRb);
            Controls.Add(ToTenthRb);
            Controls.Add(ToWholeRb);
            Controls.Add(NumTextBox);
            Controls.Add(NumLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumLbl;
        private TextBox NumTextBox;
        private RadioButton ToWholeRb;
        private RadioButton ToTenthRb;
        private RadioButton ToOneHundredRb;
        private Button RoundBtn;
        private ListBox ListBoxNums;
    }
}