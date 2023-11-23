namespace Snackbar
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
            listBox1 = new ListBox();
            ChipsAmount = new NumericUpDown();
            SodaAmount = new NumericUpDown();
            CandyAmount = new NumericUpDown();
            AddOrderButton = new Button();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            TotalPriceAllOrders = new Label();
            rbChips = new RadioButton();
            rbSoda = new RadioButton();
            rbCandy = new RadioButton();
            label1 = new Label();
            changeItemPriceButton = new Button();
            ItemNewPrice = new NumericUpDown();
            ChipsPrice = new Label();
            SodaPrice = new Label();
            CandyPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)ChipsAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SodaAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CandyAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemNewPrice).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(399, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(389, 484);
            listBox1.TabIndex = 0;
            // 
            // ChipsAmount
            // 
            ChipsAmount.Location = new Point(137, 46);
            ChipsAmount.Name = "ChipsAmount";
            ChipsAmount.Size = new Size(78, 39);
            ChipsAmount.TabIndex = 1;
            // 
            // SodaAmount
            // 
            SodaAmount.Location = new Point(137, 108);
            SodaAmount.Name = "SodaAmount";
            SodaAmount.Size = new Size(78, 39);
            SodaAmount.TabIndex = 2;
            // 
            // CandyAmount
            // 
            CandyAmount.Location = new Point(137, 169);
            CandyAmount.Name = "CandyAmount";
            CandyAmount.Size = new Size(78, 39);
            CandyAmount.TabIndex = 3;
            // 
            // AddOrderButton
            // 
            AddOrderButton.Location = new Point(12, 229);
            AddOrderButton.Name = "AddOrderButton";
            AddOrderButton.Size = new Size(300, 50);
            AddOrderButton.TabIndex = 7;
            AddOrderButton.Text = "AddOrder";
            AddOrderButton.UseVisualStyleBackColor = true;
            AddOrderButton.Click += AddOrderButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 396);
            label4.Name = "label4";
            label4.Size = new Size(29, 32);
            label4.TabIndex = 8;
            label4.Text = "...";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 441);
            label5.Name = "label5";
            label5.Size = new Size(263, 32);
            label5.TabIndex = 9;
            label5.Text = "Total price of all orders:";
            // 
            // TotalPriceAllOrders
            // 
            TotalPriceAllOrders.AutoSize = true;
            TotalPriceAllOrders.Location = new Point(281, 441);
            TotalPriceAllOrders.Name = "TotalPriceAllOrders";
            TotalPriceAllOrders.Size = new Size(29, 32);
            TotalPriceAllOrders.TabIndex = 10;
            TotalPriceAllOrders.Text = "...";
            // 
            // rbChips
            // 
            rbChips.AutoSize = true;
            rbChips.Location = new Point(12, 46);
            rbChips.Name = "rbChips";
            rbChips.Size = new Size(104, 36);
            rbChips.TabIndex = 11;
            rbChips.TabStop = true;
            rbChips.Text = "Chips";
            rbChips.UseVisualStyleBackColor = true;
            // 
            // rbSoda
            // 
            rbSoda.AutoSize = true;
            rbSoda.Location = new Point(12, 111);
            rbSoda.Name = "rbSoda";
            rbSoda.Size = new Size(98, 36);
            rbSoda.TabIndex = 12;
            rbSoda.TabStop = true;
            rbSoda.Text = "Soda";
            rbSoda.UseVisualStyleBackColor = true;
            // 
            // rbCandy
            // 
            rbCandy.AutoSize = true;
            rbCandy.Location = new Point(12, 172);
            rbCandy.Name = "rbCandy";
            rbCandy.Size = new Size(112, 36);
            rbCandy.TabIndex = 13;
            rbCandy.TabStop = true;
            rbCandy.Text = "Candy";
            rbCandy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 396);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 14;
            label1.Text = "Price of order:";
            // 
            // changeItemPriceButton
            // 
            changeItemPriceButton.Location = new Point(137, 303);
            changeItemPriceButton.Name = "changeItemPriceButton";
            changeItemPriceButton.Size = new Size(224, 46);
            changeItemPriceButton.TabIndex = 16;
            changeItemPriceButton.Text = "Change Item Price";
            changeItemPriceButton.UseVisualStyleBackColor = true;
            changeItemPriceButton.Click += changeItemPriceButton_Click;
            // 
            // ItemNewPrice
            // 
            ItemNewPrice.Location = new Point(12, 308);
            ItemNewPrice.Name = "ItemNewPrice";
            ItemNewPrice.Size = new Size(112, 39);
            ItemNewPrice.TabIndex = 17;
            // 
            // ChipsPrice
            // 
            ChipsPrice.AutoSize = true;
            ChipsPrice.Location = new Point(241, 48);
            ChipsPrice.Name = "ChipsPrice";
            ChipsPrice.Size = new Size(71, 32);
            ChipsPrice.TabIndex = 18;
            ChipsPrice.Text = "1.99€";
            // 
            // SodaPrice
            // 
            SodaPrice.Location = new Point(241, 113);
            SodaPrice.Name = "SodaPrice";
            SodaPrice.Size = new Size(156, 37);
            SodaPrice.TabIndex = 19;
            SodaPrice.Text = "0.99€";
            // 
            // CandyPrice
            // 
            CandyPrice.AutoSize = true;
            CandyPrice.Location = new Point(241, 174);
            CandyPrice.Name = "CandyPrice";
            CandyPrice.Size = new Size(71, 32);
            CandyPrice.TabIndex = 20;
            CandyPrice.Text = "2.99€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(CandyPrice);
            Controls.Add(SodaPrice);
            Controls.Add(ChipsPrice);
            Controls.Add(ItemNewPrice);
            Controls.Add(changeItemPriceButton);
            Controls.Add(label1);
            Controls.Add(rbCandy);
            Controls.Add(rbSoda);
            Controls.Add(rbChips);
            Controls.Add(TotalPriceAllOrders);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AddOrderButton);
            Controls.Add(CandyAmount);
            Controls.Add(SodaAmount);
            Controls.Add(ChipsAmount);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ChipsAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)SodaAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)CandyAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemNewPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private NumericUpDown ChipsAmount;
        private NumericUpDown SodaAmount;
        private NumericUpDown CandyAmount;
        private Button AddOrderButton;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label TotalPriceAllOrders;
        private RadioButton rbChips;
        private RadioButton rbSoda;
        private RadioButton rbCandy;
        private Label label1;
        private Button changeItemPriceButton;
        private NumericUpDown ItemNewPrice;
        private Label ChipsPrice;
        private Label SodaPrice;
        private Label CandyPrice;
    }
}