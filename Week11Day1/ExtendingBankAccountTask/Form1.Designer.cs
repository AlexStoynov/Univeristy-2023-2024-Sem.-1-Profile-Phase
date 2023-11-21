namespace ExtendingBankAccountTask
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            withdrawBtn = new Button();
            depositBtn = new Button();
            amountMoney = new TextBox();
            rbSavings = new RadioButton();
            rbChecking = new RadioButton();
            checkingAccBalance = new Label();
            savingsAccBalance = new Label();
            insufficientFundsLbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 0;
            label1.Text = "Checking account balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(346, 37);
            label2.TabIndex = 1;
            label2.Text = "Savings account balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 57);
            label3.Name = "label3";
            label3.Size = new Size(314, 32);
            label3.TabIndex = 2;
            label3.Text = "Please select a bank account:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(6, 259);
            label4.Name = "label4";
            label4.Size = new Size(215, 32);
            label4.TabIndex = 3;
            label4.Text = "Amount in euros: ";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(withdrawBtn);
            groupBox1.Controls.Add(depositBtn);
            groupBox1.Controls.Add(amountMoney);
            groupBox1.Controls.Add(rbSavings);
            groupBox1.Controls.Add(rbChecking);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 406);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(312, 339);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(187, 46);
            withdrawBtn.TabIndex = 8;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(31, 339);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(195, 46);
            depositBtn.TabIndex = 7;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // amountMoney
            // 
            amountMoney.Location = new Point(31, 294);
            amountMoney.Name = "amountMoney";
            amountMoney.Size = new Size(468, 39);
            amountMoney.TabIndex = 6;
            // 
            // rbSavings
            // 
            rbSavings.AutoSize = true;
            rbSavings.Location = new Point(31, 167);
            rbSavings.Name = "rbSavings";
            rbSavings.Size = new Size(220, 36);
            rbSavings.TabIndex = 5;
            rbSavings.TabStop = true;
            rbSavings.Text = "Savings Account";
            rbSavings.UseVisualStyleBackColor = true;
            rbSavings.CheckedChanged += rbSavings_CheckedChanged;
            // 
            // rbChecking
            // 
            rbChecking.AutoSize = true;
            rbChecking.Location = new Point(31, 106);
            rbChecking.Name = "rbChecking";
            rbChecking.Size = new Size(238, 36);
            rbChecking.TabIndex = 4;
            rbChecking.TabStop = true;
            rbChecking.Text = "Checking Account";
            rbChecking.UseVisualStyleBackColor = true;
            rbChecking.CheckedChanged += rbChecking_CheckedChanged;
            // 
            // checkingAccBalance
            // 
            checkingAccBalance.AutoSize = true;
            checkingAccBalance.Location = new Point(374, 36);
            checkingAccBalance.Name = "checkingAccBalance";
            checkingAccBalance.Size = new Size(29, 32);
            checkingAccBalance.TabIndex = 5;
            checkingAccBalance.Text = "...";
            // 
            // savingsAccBalance
            // 
            savingsAccBalance.AutoSize = true;
            savingsAccBalance.Location = new Point(364, 93);
            savingsAccBalance.Name = "savingsAccBalance";
            savingsAccBalance.Size = new Size(29, 32);
            savingsAccBalance.TabIndex = 6;
            savingsAccBalance.Text = "...";
            // 
            // insufficientFundsLbl
            // 
            insufficientFundsLbl.AutoSize = true;
            insufficientFundsLbl.Location = new Point(43, 571);
            insufficientFundsLbl.Name = "insufficientFundsLbl";
            insufficientFundsLbl.Size = new Size(29, 32);
            insufficientFundsLbl.TabIndex = 9;
            insufficientFundsLbl.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 627);
            Controls.Add(insufficientFundsLbl);
            Controls.Add(savingsAccBalance);
            Controls.Add(checkingAccBalance);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbSavings;
        private RadioButton rbChecking;
        private Button withdrawBtn;
        private Button depositBtn;
        private TextBox amountMoney;
        private Label checkingAccBalance;
        private Label savingsAccBalance;
        private Label insufficientFundsLbl;
    }
}