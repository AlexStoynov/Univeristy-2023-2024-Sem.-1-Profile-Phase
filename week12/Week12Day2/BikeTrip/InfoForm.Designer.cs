namespace BikeTrip
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TripsInfo = new ListBox();
            groupBox1 = new GroupBox();
            ShowInfoBtn = new Button();
            groupBox2 = new GroupBox();
            showAvgTb = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TripsInfo
            // 
            TripsInfo.FormattingEnabled = true;
            TripsInfo.ItemHeight = 32;
            TripsInfo.Location = new Point(6, 38);
            TripsInfo.Name = "TripsInfo";
            TripsInfo.Size = new Size(354, 324);
            TripsInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ShowInfoBtn);
            groupBox1.Controls.Add(TripsInfo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Show Info";
            // 
            // ShowInfoBtn
            // 
            ShowInfoBtn.Location = new Point(6, 374);
            ShowInfoBtn.Name = "ShowInfoBtn";
            ShowInfoBtn.Size = new Size(354, 46);
            ShowInfoBtn.TabIndex = 2;
            ShowInfoBtn.Text = "Show Info";
            ShowInfoBtn.UseVisualStyleBackColor = true;
            ShowInfoBtn.Click += ShowInfoBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(showAvgTb);
            groupBox2.Location = new Point(401, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 236);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Show Average";
            // 
            // showAvgTb
            // 
            showAvgTb.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            showAvgTb.Location = new Point(6, 38);
            showAvgTb.Multiline = true;
            showAvgTb.Name = "showAvgTb";
            showAvgTb.Size = new Size(375, 178);
            showAvgTb.TabIndex = 2;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "InfoForm";
            Text = "InfoForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox TripsInfo;
        private GroupBox groupBox1;
        private Button ShowInfoBtn;
        private GroupBox groupBox2;
        private TextBox showAvgTb;
    }
}