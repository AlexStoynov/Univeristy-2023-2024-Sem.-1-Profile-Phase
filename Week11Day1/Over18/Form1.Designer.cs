namespace Over18
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
            rbLemonade = new RadioButton();
            rbBeer = new RadioButton();
            cbOver18 = new CheckBox();
            orderBtn = new Button();
            outputLbl = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // rbLemonade
            // 
            rbLemonade.AutoSize = true;
            rbLemonade.Location = new Point(52, 151);
            rbLemonade.Name = "rbLemonade";
            rbLemonade.Size = new Size(157, 36);
            rbLemonade.TabIndex = 0;
            rbLemonade.TabStop = true;
            rbLemonade.Text = "Lemonade";
            rbLemonade.UseVisualStyleBackColor = true;
            rbLemonade.CheckedChanged += rbLemonade_CheckedChanged;
            // 
            // rbBeer
            // 
            rbBeer.AutoSize = true;
            rbBeer.Location = new Point(270, 151);
            rbBeer.Name = "rbBeer";
            rbBeer.Size = new Size(93, 36);
            rbBeer.TabIndex = 1;
            rbBeer.TabStop = true;
            rbBeer.Text = "Beer";
            rbBeer.UseVisualStyleBackColor = true;
            rbBeer.CheckedChanged += rbBeer_CheckedChanged;
            // 
            // cbOver18
            // 
            cbOver18.AutoSize = true;
            cbOver18.Location = new Point(52, 223);
            cbOver18.Name = "cbOver18";
            cbOver18.Size = new Size(141, 36);
            cbOver18.TabIndex = 2;
            cbOver18.Text = "Over 18?";
            cbOver18.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(52, 286);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(215, 62);
            orderBtn.TabIndex = 3;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // outputLbl
            // 
            outputLbl.AutoSize = true;
            outputLbl.Location = new Point(52, 375);
            outputLbl.Name = "outputLbl";
            outputLbl.Size = new Size(29, 32);
            outputLbl.TabIndex = 4;
            outputLbl.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 58);
            label1.Name = "label1";
            label1.Size = new Size(387, 50);
            label1.TabIndex = 5;
            label1.Text = "Welcome to the bar!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(outputLbl);
            Controls.Add(orderBtn);
            Controls.Add(cbOver18);
            Controls.Add(rbBeer);
            Controls.Add(rbLemonade);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbLemonade;
        private RadioButton rbBeer;
        private CheckBox cbOver18;
        private Button orderBtn;
        private Label outputLbl;
        private Label label1;
    }
}