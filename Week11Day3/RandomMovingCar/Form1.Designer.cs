namespace RandomMovingCar
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
            components = new System.ComponentModel.Container();
            startCarBtn = new Button();
            picBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // startCarBtn
            // 
            startCarBtn.Location = new Point(12, 353);
            startCarBtn.Name = "startCarBtn";
            startCarBtn.Size = new Size(150, 46);
            startCarBtn.TabIndex = 0;
            startCarBtn.Text = "Start Car";
            startCarBtn.UseVisualStyleBackColor = true;
            startCarBtn.Click += startCarBtn_Click;
            // 
            // picBox
            // 
            picBox.Image = Properties.Resources._21zqwas1;
            picBox.Location = new Point(12, 145);
            picBox.Name = "picBox";
            picBox.Size = new Size(569, 183);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += picBox_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 451);
            Controls.Add(picBox);
            Controls.Add(startCarBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startCarBtn;
        private PictureBox picBox;
        private System.Windows.Forms.Timer timer1;
    }
}