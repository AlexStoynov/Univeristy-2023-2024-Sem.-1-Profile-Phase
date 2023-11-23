namespace Lottery
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
            WantedNums = new TextBox();
            MaxValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NumbersDrawnBox = new ListBox();
            CreateLotteryObjBtn = new Button();
            DrawNextNumBtn = new Button();
            DrawNumsAtOnceBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WantedNums);
            groupBox1.Controls.Add(MaxValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery settings";
            // 
            // WantedNums
            // 
            WantedNums.Location = new Point(276, 130);
            WantedNums.Name = "WantedNums";
            WantedNums.Size = new Size(153, 39);
            WantedNums.TabIndex = 3;
            // 
            // MaxValue
            // 
            MaxValue.Location = new Point(147, 63);
            MaxValue.Name = "MaxValue";
            MaxValue.Size = new Size(200, 39);
            MaxValue.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 130);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "Wanted numbers count:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Max value: ";
            // 
            // NumbersDrawnBox
            // 
            NumbersDrawnBox.FormattingEnabled = true;
            NumbersDrawnBox.ItemHeight = 32;
            NumbersDrawnBox.Location = new Point(492, 12);
            NumbersDrawnBox.Name = "NumbersDrawnBox";
            NumbersDrawnBox.Size = new Size(296, 516);
            NumbersDrawnBox.TabIndex = 1;
            NumbersDrawnBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CreateLotteryObjBtn
            // 
            CreateLotteryObjBtn.Location = new Point(12, 244);
            CreateLotteryObjBtn.Name = "CreateLotteryObjBtn";
            CreateLotteryObjBtn.Size = new Size(456, 46);
            CreateLotteryObjBtn.TabIndex = 2;
            CreateLotteryObjBtn.Text = "Create lottery object";
            CreateLotteryObjBtn.UseVisualStyleBackColor = true;
            CreateLotteryObjBtn.Click += CreateLotteryObjBtn_Click;
            // 
            // DrawNextNumBtn
            // 
            DrawNextNumBtn.Location = new Point(12, 305);
            DrawNextNumBtn.Name = "DrawNextNumBtn";
            DrawNextNumBtn.Size = new Size(456, 46);
            DrawNextNumBtn.TabIndex = 3;
            DrawNextNumBtn.Text = "Draw next number";
            DrawNextNumBtn.UseVisualStyleBackColor = true;
            DrawNextNumBtn.Click += DrawNextNumBtn_Click;
            // 
            // DrawNumsAtOnceBtn
            // 
            DrawNumsAtOnceBtn.Location = new Point(12, 368);
            DrawNumsAtOnceBtn.Name = "DrawNumsAtOnceBtn";
            DrawNumsAtOnceBtn.Size = new Size(456, 46);
            DrawNumsAtOnceBtn.TabIndex = 4;
            DrawNumsAtOnceBtn.Text = "Draw all numbers at once";
            DrawNumsAtOnceBtn.UseVisualStyleBackColor = true;
            DrawNumsAtOnceBtn.Click += DrawNumsAtOnceBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(DrawNumsAtOnceBtn);
            Controls.Add(DrawNextNumBtn);
            Controls.Add(CreateLotteryObjBtn);
            Controls.Add(NumbersDrawnBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox WantedNums;
        private TextBox MaxValue;
        private Label label2;
        private Label label1;
        private ListBox NumbersDrawnBox;
        private Button CreateLotteryObjBtn;
        private Button DrawNextNumBtn;
        private Button DrawNumsAtOnceBtn;
    }
}