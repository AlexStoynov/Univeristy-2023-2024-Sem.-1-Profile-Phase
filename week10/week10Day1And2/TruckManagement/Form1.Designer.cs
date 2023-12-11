namespace TruckManagement
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
            label2 = new Label();
            label1 = new Label();
            TypeABoxesNum = new TextBox();
            TypeAPalletsNum = new TextBox();
            groupBox2 = new GroupBox();
            TypeBPalletsNum = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TypeBBoxesNum = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            TypeCBoxesNum = new TextBox();
            textBox3 = new TextBox();
            TypeCPalletsNum = new TextBox();
            groupBox4 = new GroupBox();
            result = new Label();
            CalculateButton = new Button();
            TypeCRadio = new RadioButton();
            TypeBRadio = new RadioButton();
            TypeARadio = new RadioButton();
            label8 = new Label();
            label7 = new Label();
            BoxesForShipping = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TypeABoxesNum);
            groupBox1.Controls.Add(TypeAPalletsNum);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Truck A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 119);
            label2.Name = "label2";
            label2.Size = new Size(338, 32);
            label2.TabIndex = 3;
            label2.Text = "Max num. of boxes per pallet: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(339, 32);
            label1.TabIndex = 2;
            label1.Text = "Max num. of pallets per truck: ";
            // 
            // TypeABoxesNum
            // 
            TypeABoxesNum.Location = new Point(351, 119);
            TypeABoxesNum.Name = "TypeABoxesNum";
            TypeABoxesNum.Size = new Size(82, 39);
            TypeABoxesNum.TabIndex = 1;
            // 
            // TypeAPalletsNum
            // 
            TypeAPalletsNum.Location = new Point(351, 45);
            TypeAPalletsNum.Name = "TypeAPalletsNum";
            TypeAPalletsNum.Size = new Size(82, 39);
            TypeAPalletsNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TypeBPalletsNum);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TypeBBoxesNum);
            groupBox2.Location = new Point(12, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Truck B";
            // 
            // TypeBPalletsNum
            // 
            TypeBPalletsNum.Location = new Point(351, 45);
            TypeBPalletsNum.Name = "TypeBPalletsNum";
            TypeBPalletsNum.Size = new Size(82, 39);
            TypeBPalletsNum.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(338, 32);
            label4.TabIndex = 3;
            label4.Text = "Max num. of boxes per pallet: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 45);
            label3.Name = "label3";
            label3.Size = new Size(339, 32);
            label3.TabIndex = 2;
            label3.Text = "Max num. of pallets per truck: ";
            // 
            // TypeBBoxesNum
            // 
            TypeBBoxesNum.Location = new Point(351, 100);
            TypeBBoxesNum.Name = "TypeBBoxesNum";
            TypeBBoxesNum.Size = new Size(82, 39);
            TypeBBoxesNum.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TypeCBoxesNum);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(TypeCPalletsNum);
            groupBox3.Location = new Point(12, 448);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(515, 156);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Truck C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 102);
            label6.Name = "label6";
            label6.Size = new Size(338, 32);
            label6.TabIndex = 3;
            label6.Text = "Max num. of boxes per pallet: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(339, 32);
            label5.TabIndex = 2;
            label5.Text = "Max num. of pallets per truck: ";
            label5.Click += label5_Click;
            // 
            // TypeCBoxesNum
            // 
            TypeCBoxesNum.Location = new Point(351, 99);
            TypeCBoxesNum.Name = "TypeCBoxesNum";
            TypeCBoxesNum.Size = new Size(82, 39);
            TypeCBoxesNum.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, -179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(82, 39);
            textBox3.TabIndex = 0;
            // 
            // TypeCPalletsNum
            // 
            TypeCPalletsNum.Location = new Point(351, 38);
            TypeCPalletsNum.Name = "TypeCPalletsNum";
            TypeCPalletsNum.Size = new Size(82, 39);
            TypeCPalletsNum.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(result);
            groupBox4.Controls.Add(CalculateButton);
            groupBox4.Controls.Add(TypeCRadio);
            groupBox4.Controls.Add(TypeBRadio);
            groupBox4.Controls.Add(TypeARadio);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(BoxesForShipping);
            groupBox4.Location = new Point(598, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(638, 592);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Orders Info";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(6, 382);
            result.Name = "result";
            result.Size = new Size(78, 32);
            result.TabIndex = 4;
            result.Text = "label9";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(28, 275);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(238, 78);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // TypeCRadio
            // 
            TypeCRadio.AutoSize = true;
            TypeCRadio.Location = new Point(291, 191);
            TypeCRadio.Name = "TypeCRadio";
            TypeCRadio.Size = new Size(118, 36);
            TypeCRadio.TabIndex = 5;
            TypeCRadio.TabStop = true;
            TypeCRadio.Text = "Type C";
            TypeCRadio.UseVisualStyleBackColor = true;
            TypeCRadio.CheckedChanged += TypeCRadio_CheckedChanged;
            // 
            // TypeBRadio
            // 
            TypeBRadio.AutoSize = true;
            TypeBRadio.Location = new Point(291, 149);
            TypeBRadio.Name = "TypeBRadio";
            TypeBRadio.Size = new Size(117, 36);
            TypeBRadio.TabIndex = 4;
            TypeBRadio.TabStop = true;
            TypeBRadio.Text = "Type B";
            TypeBRadio.UseVisualStyleBackColor = true;
            TypeBRadio.CheckedChanged += TypeBRadio_CheckedChanged;
            // 
            // TypeARadio
            // 
            TypeARadio.AutoSize = true;
            TypeARadio.Location = new Point(291, 104);
            TypeARadio.Name = "TypeARadio";
            TypeARadio.Size = new Size(118, 36);
            TypeARadio.TabIndex = 3;
            TypeARadio.TabStop = true;
            TypeARadio.Text = "Type A";
            TypeARadio.UseVisualStyleBackColor = true;
            TypeARadio.CheckedChanged += TypeARadio_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 108);
            label8.Name = "label8";
            label8.Size = new Size(257, 32);
            label8.TabIndex = 2;
            label8.Text = "Truck type to be used: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 41);
            label7.Name = "label7";
            label7.Size = new Size(367, 32);
            label7.TabIndex = 1;
            label7.Text = "Number of boxes to be shipped: ";
            // 
            // BoxesForShipping
            // 
            BoxesForShipping.Location = new Point(379, 38);
            BoxesForShipping.Name = "BoxesForShipping";
            BoxesForShipping.Size = new Size(136, 39);
            BoxesForShipping.TabIndex = 0;
            BoxesForShipping.TextChanged += textBox7_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 633);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox TypeABoxesNum;
        private TextBox TypeAPalletsNum;
        private TextBox TypeBBoxesNum;
        private TextBox textBox3;
        private TextBox TypeCBoxesNum;
        private TextBox TypeCPalletsNum;
        private GroupBox groupBox4;
        private TextBox BoxesForShipping;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox TypeBPalletsNum;
        private Label label7;
        private RadioButton TypeCRadio;
        private RadioButton TypeBRadio;
        private RadioButton TypeARadio;
        private Label label8;
        private Button CalculateButton;
        private Label result;
    }
}