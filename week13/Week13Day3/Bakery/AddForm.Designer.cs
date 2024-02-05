
namespace Bakery
{
    partial class AddForm
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
            label1 = new System.Windows.Forms.Label();
            cbbBreadFilter = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tbxName = new System.Windows.Forms.TextBox();
            listBoxIng = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 42);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Bread:";
            // 
            // cbbBreadFilter
            // 
            cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbBreadFilter.FormattingEnabled = true;
            cbbBreadFilter.Items.AddRange(new object[] { "Ciabatta", "Focaccia", "Sour Dough", "Rye", "Whole Wheat" });
            cbbBreadFilter.Location = new System.Drawing.Point(100, 40);
            cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbbBreadFilter.Name = "cbbBreadFilter";
            cbbBreadFilter.Size = new System.Drawing.Size(379, 28);
            cbbBreadFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 69);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 9;
            label2.Text = "Ingredients:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(13, 245);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(459, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Sandwich";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 14);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new System.Drawing.Point(100, 12);
            tbxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tbxName.Name = "tbxName";
            tbxName.Size = new System.Drawing.Size(379, 27);
            tbxName.TabIndex = 12;
            // 
            // listBoxIng
            // 
            listBoxIng.FormattingEnabled = true;
            listBoxIng.ItemHeight = 20;
            listBoxIng.Location = new System.Drawing.Point(100, 73);
            listBoxIng.Name = "listBoxIng";
            listBoxIng.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            listBoxIng.Size = new System.Drawing.Size(372, 164);
            listBoxIng.TabIndex = 13;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(492, 281);
            Controls.Add(listBoxIng);
            Controls.Add(tbxName);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbBreadFilter);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "AddForm";
            Text = "Add New Sandwich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ListBox listBoxIng;
    }
}

