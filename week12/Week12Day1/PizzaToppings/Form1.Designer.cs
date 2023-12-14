namespace PizzaToppings
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
            addToppingBtn = new Button();
            RemoveToppingBtn = new Button();
            toppingsCb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // addToppingBtn
            // 
            addToppingBtn.Location = new Point(533, 24);
            addToppingBtn.Name = "addToppingBtn";
            addToppingBtn.Size = new Size(238, 78);
            addToppingBtn.TabIndex = 0;
            addToppingBtn.Text = "Add topping";
            addToppingBtn.UseVisualStyleBackColor = true;
            addToppingBtn.Click += addToppingBtn_Click;
            // 
            // RemoveToppingBtn
            // 
            RemoveToppingBtn.Location = new Point(533, 130);
            RemoveToppingBtn.Name = "RemoveToppingBtn";
            RemoveToppingBtn.Size = new Size(238, 78);
            RemoveToppingBtn.TabIndex = 1;
            RemoveToppingBtn.Text = "Remove topping";
            RemoveToppingBtn.UseVisualStyleBackColor = true;
            RemoveToppingBtn.Click += RemoveToppingBtn_Click;
            // 
            // toppingsCb
            // 
            toppingsCb.FormattingEnabled = true;
            toppingsCb.Items.AddRange(new object[] { "ham", "mushrooms", "pepperoni", "corn", "chicken" });
            toppingsCb.Location = new Point(55, 24);
            toppingsCb.Name = "toppingsCb";
            toppingsCb.Size = new Size(266, 40);
            toppingsCb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 309);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 3;
            label1.Text = "Pizza with:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 365);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 4;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 309);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 365);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toppingsCb);
            Controls.Add(RemoveToppingBtn);
            Controls.Add(addToppingBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addToppingBtn;
        private Button RemoveToppingBtn;
        private ComboBox toppingsCb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}