namespace CarApp
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
            AccelerateButton = new Button();
            BrakeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AccelerateButton
            // 
            AccelerateButton.Location = new Point(32, 333);
            AccelerateButton.Name = "AccelerateButton";
            AccelerateButton.Size = new Size(306, 59);
            AccelerateButton.TabIndex = 0;
            AccelerateButton.Text = "Accelerate";
            AccelerateButton.UseVisualStyleBackColor = true;
            AccelerateButton.Click += button1_Click;
            // 
            // BrakeButton
            // 
            BrakeButton.Location = new Point(386, 333);
            BrakeButton.Name = "BrakeButton";
            BrakeButton.Size = new Size(306, 59);
            BrakeButton.TabIndex = 1;
            BrakeButton.Text = "Use Breaks";
            BrakeButton.UseVisualStyleBackColor = true;
            BrakeButton.Click += BrakeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BrakeButton);
            Controls.Add(AccelerateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AccelerateButton;
        private Button BrakeButton;
        private Label label1;
        private Label label2;
    }
}