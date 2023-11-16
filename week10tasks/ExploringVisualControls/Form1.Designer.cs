namespace ExploringVisualControls
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
            button1 = new Button();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            rbMakeRed = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Location = new Point(60, 49);
            button1.Name = "button1";
            button1.Size = new Size(191, 63);
            button1.TabIndex = 0;
            button1.Text = "Who am I??";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(128, 255, 128);
            trackBar1.Location = new Point(60, 152);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(776, 90);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 20;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(60, 328);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(650, 60);
            progressBar1.TabIndex = 2;
            progressBar1.Value = 40;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 267);
            label1.Name = "label1";
            label1.Size = new Size(54, 45);
            label1.TabIndex = 3;
            label1.Text = "73";
            // 
            // rbMakeRed
            // 
            rbMakeRed.AutoSize = true;
            rbMakeRed.Location = new Point(896, 51);
            rbMakeRed.Name = "rbMakeRed";
            rbMakeRed.Size = new Size(146, 36);
            rbMakeRed.TabIndex = 4;
            rbMakeRed.TabStop = true;
            rbMakeRed.Text = "Make red";
            rbMakeRed.UseVisualStyleBackColor = true;
            rbMakeRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(897, 136);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(184, 36);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(897, 220);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(184, 36);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 454);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(rbMakeRed);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private Label label1;
        private RadioButton rbMakeRed;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}