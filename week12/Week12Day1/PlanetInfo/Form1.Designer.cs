namespace PlanetInfo
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
            MercuryBtn = new Button();
            VenusBtn = new Button();
            EarthBtn = new Button();
            MarsBtn = new Button();
            JupiterBtn = new Button();
            GravityLbl = new Label();
            DiameterLbl = new Label();
            SuspendLayout();
            // 
            // MercuryBtn
            // 
            MercuryBtn.Location = new Point(12, 12);
            MercuryBtn.Name = "MercuryBtn";
            MercuryBtn.Size = new Size(364, 46);
            MercuryBtn.TabIndex = 0;
            MercuryBtn.Text = "Mercury";
            MercuryBtn.UseVisualStyleBackColor = true;
            MercuryBtn.Click += MercuryBtn_Click;
            // 
            // VenusBtn
            // 
            VenusBtn.Location = new Point(12, 81);
            VenusBtn.Name = "VenusBtn";
            VenusBtn.Size = new Size(364, 46);
            VenusBtn.TabIndex = 1;
            VenusBtn.Text = "Venus";
            VenusBtn.UseVisualStyleBackColor = true;
            VenusBtn.Click += VenusBtn_Click;
            // 
            // EarthBtn
            // 
            EarthBtn.Location = new Point(12, 149);
            EarthBtn.Name = "EarthBtn";
            EarthBtn.Size = new Size(364, 46);
            EarthBtn.TabIndex = 2;
            EarthBtn.Text = "Earth";
            EarthBtn.UseVisualStyleBackColor = true;
            EarthBtn.Click += EarthBtn_Click;
            // 
            // MarsBtn
            // 
            MarsBtn.Location = new Point(12, 214);
            MarsBtn.Name = "MarsBtn";
            MarsBtn.Size = new Size(364, 46);
            MarsBtn.TabIndex = 3;
            MarsBtn.Text = "Mars";
            MarsBtn.UseVisualStyleBackColor = true;
            MarsBtn.Click += MarsBtn_Click;
            // 
            // JupiterBtn
            // 
            JupiterBtn.Location = new Point(12, 278);
            JupiterBtn.Name = "JupiterBtn";
            JupiterBtn.Size = new Size(364, 46);
            JupiterBtn.TabIndex = 4;
            JupiterBtn.Text = "Jupiter";
            JupiterBtn.UseVisualStyleBackColor = true;
            JupiterBtn.Click += JupiterBtn_Click;
            // 
            // GravityLbl
            // 
            GravityLbl.AutoSize = true;
            GravityLbl.Location = new Point(457, 88);
            GravityLbl.Name = "GravityLbl";
            GravityLbl.Size = new Size(29, 32);
            GravityLbl.TabIndex = 5;
            GravityLbl.Text = "...";
            // 
            // DiameterLbl
            // 
            DiameterLbl.AutoSize = true;
            DiameterLbl.Location = new Point(457, 228);
            DiameterLbl.Name = "DiameterLbl";
            DiameterLbl.Size = new Size(29, 32);
            DiameterLbl.TabIndex = 6;
            DiameterLbl.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 334);
            Controls.Add(DiameterLbl);
            Controls.Add(GravityLbl);
            Controls.Add(JupiterBtn);
            Controls.Add(MarsBtn);
            Controls.Add(EarthBtn);
            Controls.Add(VenusBtn);
            Controls.Add(MercuryBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MercuryBtn;
        private Button VenusBtn;
        private Button EarthBtn;
        private Button MarsBtn;
        private Button JupiterBtn;
        private Label GravityLbl;
        private Label DiameterLbl;
    }
}