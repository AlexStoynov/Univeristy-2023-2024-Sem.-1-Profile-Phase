namespace SeasonApp
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
            SeasonLbl = new Label();
            nextSeasonBtn = new Button();
            SuspendLayout();
            // 
            // SeasonLbl
            // 
            SeasonLbl.AutoSize = true;
            SeasonLbl.Location = new Point(84, 66);
            SeasonLbl.Name = "SeasonLbl";
            SeasonLbl.Size = new Size(83, 32);
            SeasonLbl.TabIndex = 0;
            SeasonLbl.Text = "Spring";
            // 
            // nextSeasonBtn
            // 
            nextSeasonBtn.Location = new Point(53, 158);
            nextSeasonBtn.Name = "nextSeasonBtn";
            nextSeasonBtn.Size = new Size(150, 46);
            nextSeasonBtn.TabIndex = 1;
            nextSeasonBtn.Text = "next";
            nextSeasonBtn.UseVisualStyleBackColor = true;
            nextSeasonBtn.Click += nextSeasonBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 268);
            Controls.Add(nextSeasonBtn);
            Controls.Add(SeasonLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SeasonLbl;
        private Button nextSeasonBtn;
    }
}