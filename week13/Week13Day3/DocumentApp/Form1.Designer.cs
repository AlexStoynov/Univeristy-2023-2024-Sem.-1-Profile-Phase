namespace DocumentApp
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
            DocumentText = new TextBox();
            DocumentTitle = new TextBox();
            SaveToTxtBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // DocumentText
            // 
            DocumentText.Location = new Point(12, 83);
            DocumentText.Multiline = true;
            DocumentText.Name = "DocumentText";
            DocumentText.Size = new Size(662, 303);
            DocumentText.TabIndex = 0;
            // 
            // DocumentTitle
            // 
            DocumentTitle.Location = new Point(83, 27);
            DocumentTitle.Name = "DocumentTitle";
            DocumentTitle.Size = new Size(200, 39);
            DocumentTitle.TabIndex = 1;
            // 
            // SaveToTxtBtn
            // 
            SaveToTxtBtn.Location = new Point(12, 392);
            SaveToTxtBtn.Name = "SaveToTxtBtn";
            SaveToTxtBtn.Size = new Size(662, 46);
            SaveToTxtBtn.TabIndex = 2;
            SaveToTxtBtn.Text = "Save to file";
            SaveToTxtBtn.UseVisualStyleBackColor = true;
            SaveToTxtBtn.Click += SaveToTxtBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 3;
            label1.Text = "Title:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(label1);
            Controls.Add(SaveToTxtBtn);
            Controls.Add(DocumentTitle);
            Controls.Add(DocumentText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DocumentText;
        private TextBox DocumentTitle;
        private Button SaveToTxtBtn;
        private Label label1;
    }
}