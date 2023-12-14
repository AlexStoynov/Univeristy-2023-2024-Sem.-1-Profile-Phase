namespace RandomPasswordGenerator
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
            listBox1 = new ListBox();
            generatePassBtn = new Button();
            passLength = new NumericUpDown();
            passAmount = new NumericUpDown();
            specialSymbolsCB = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)passLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passAmount).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(12, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 324);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // generatePassBtn
            // 
            generatePassBtn.Location = new Point(12, 256);
            generatePassBtn.Name = "generatePassBtn";
            generatePassBtn.Size = new Size(388, 46);
            generatePassBtn.TabIndex = 1;
            generatePassBtn.Text = "Generate password(s)";
            generatePassBtn.UseVisualStyleBackColor = true;
            generatePassBtn.Click += generatePassBtn_Click;
            // 
            // passLength
            // 
            passLength.Location = new Point(210, 26);
            passLength.Name = "passLength";
            passLength.Size = new Size(111, 39);
            passLength.TabIndex = 2;
            // 
            // passAmount
            // 
            passAmount.Location = new Point(268, 87);
            passAmount.Name = "passAmount";
            passAmount.Size = new Size(92, 39);
            passAmount.TabIndex = 3;
            // 
            // specialSymbolsCB
            // 
            specialSymbolsCB.AutoSize = true;
            specialSymbolsCB.Location = new Point(12, 203);
            specialSymbolsCB.Name = "specialSymbolsCB";
            specialSymbolsCB.Size = new Size(388, 36);
            specialSymbolsCB.TabIndex = 4;
            specialSymbolsCB.Text = "Include symbols (e.g. $, *, ! etc. )";
            specialSymbolsCB.UseVisualStyleBackColor = true;
            specialSymbolsCB.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 5;
            label1.Text = "Password length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(250, 32);
            label2.TabIndex = 6;
            label2.Text = "Amount of passwords:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 658);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(specialSymbolsCB);
            Controls.Add(passAmount);
            Controls.Add(passLength);
            Controls.Add(generatePassBtn);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)passLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)passAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button generatePassBtn;
        private NumericUpDown passLength;
        private NumericUpDown passAmount;
        private CheckBox specialSymbolsCB;
        private Label label1;
        private Label label2;
    }
}