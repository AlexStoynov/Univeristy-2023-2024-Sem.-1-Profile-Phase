namespace FinancesApp
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
            groupBox1 = new GroupBox();
            ExpenseName = new TextBox();
            ExpenseAmount = new NumericUpDown();
            AddExpense = new Button();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            showAllExpensesBtn = new Button();
            showExpWithSameAmountBtn = new Button();
            amount2 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExpenseName);
            groupBox1.Controls.Add(ExpenseAmount);
            groupBox1.Controls.Add(AddExpense);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense form";
            // 
            // ExpenseName
            // 
            ExpenseName.Location = new Point(102, 46);
            ExpenseName.Name = "ExpenseName";
            ExpenseName.Size = new Size(291, 39);
            ExpenseName.TabIndex = 8;
            // 
            // ExpenseAmount
            // 
            ExpenseAmount.Location = new Point(118, 101);
            ExpenseAmount.Name = "ExpenseAmount";
            ExpenseAmount.Size = new Size(108, 39);
            ExpenseAmount.TabIndex = 7;
            ExpenseAmount.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // AddExpense
            // 
            AddExpense.AutoSize = true;
            AddExpense.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            AddExpense.Location = new Point(148, 146);
            AddExpense.Name = "AddExpense";
            AddExpense.Size = new Size(245, 85);
            AddExpense.TabIndex = 3;
            AddExpense.Text = "Add expense to\r\n\r\n transaction log";
            AddExpense.UseVisualStyleBackColor = true;
            AddExpense.Click += AddExpense_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 1;
            label2.Text = "Amount: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(432, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(356, 420);
            listBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 343);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Amount: ";
            // 
            // showAllExpensesBtn
            // 
            showAllExpensesBtn.Location = new Point(12, 259);
            showAllExpensesBtn.Name = "showAllExpensesBtn";
            showAllExpensesBtn.Size = new Size(399, 43);
            showAllExpensesBtn.TabIndex = 4;
            showAllExpensesBtn.Text = "Show all expenses";
            showAllExpensesBtn.UseVisualStyleBackColor = true;
            showAllExpensesBtn.Click += button2_Click;
            // 
            // showExpWithSameAmountBtn
            // 
            showExpWithSameAmountBtn.Location = new Point(12, 402);
            showExpWithSameAmountBtn.Name = "showExpWithSameAmountBtn";
            showExpWithSameAmountBtn.Size = new Size(399, 36);
            showExpWithSameAmountBtn.TabIndex = 5;
            showExpWithSameAmountBtn.Text = "Show expenses with same amount";
            showExpWithSameAmountBtn.UseVisualStyleBackColor = true;
            showExpWithSameAmountBtn.Click += showExpWithSameAmountBtn_Click;
            // 
            // amount2
            // 
            amount2.Location = new Point(130, 336);
            amount2.Name = "amount2";
            amount2.Size = new Size(281, 39);
            amount2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(amount2);
            Controls.Add(showAllExpensesBtn);
            Controls.Add(showExpWithSameAmountBtn);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpenseAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button showAllExpensesBtn;
        private Button AddExpense;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Label label3;
        private Button showExpWithSameAmountBtn;
        private TextBox ExpenseName;
        private NumericUpDown ExpenseAmount;
        private NumericUpDown amount2;
    }
}