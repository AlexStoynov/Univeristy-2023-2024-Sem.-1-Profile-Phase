namespace DiceRolling
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
            rollsNum = new NumericUpDown();
            rollBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)rollsNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "Amount of dice to roll: ";
            // 
            // rollsNum
            // 
            rollsNum.Location = new Point(280, 20);
            rollsNum.Name = "rollsNum";
            rollsNum.Size = new Size(138, 39);
            rollsNum.TabIndex = 1;
            // 
            // rollBtn
            // 
            rollBtn.Location = new Point(12, 70);
            rollBtn.Name = "rollBtn";
            rollBtn.Size = new Size(406, 46);
            rollBtn.TabIndex = 2;
            rollBtn.Text = "Roll dice";
            rollBtn.UseVisualStyleBackColor = true;
            rollBtn.Click += rollBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 154);
            Controls.Add(rollBtn);
            Controls.Add(rollsNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)rollsNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown rollsNum;
        private Button rollBtn;
    }
}