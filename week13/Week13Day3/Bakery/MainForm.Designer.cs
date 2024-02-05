
namespace Bakery
{
    partial class MainForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnShowOfferedSandwiches = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cbbBreadFilter = new System.Windows.Forms.ComboBox();
            btnAddSandwich = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lbxMenu = new System.Windows.Forms.ListBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnRevenue = new System.Windows.Forms.Button();
            btnSell = new System.Windows.Forms.Button();
            lblSandwichInfo = new System.Windows.Forms.Label();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowOfferedSandwiches);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbBreadFilter);
            groupBox1.Controls.Add(btnAddSandwich);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(lbxMenu);
            groupBox1.Location = new System.Drawing.Point(7, 1);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(345, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnShowOfferedSandwiches
            // 
            btnShowOfferedSandwiches.Location = new System.Drawing.Point(4, 52);
            btnShowOfferedSandwiches.Margin = new System.Windows.Forms.Padding(2);
            btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            btnShowOfferedSandwiches.Size = new System.Drawing.Size(337, 29);
            btnShowOfferedSandwiches.TabIndex = 6;
            btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            btnShowOfferedSandwiches.Click += btnShowOfferedSandwiches_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 26);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Bread filter:";
            // 
            // cbbBreadFilter
            // 
            cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbBreadFilter.FormattingEnabled = true;
            cbbBreadFilter.Items.AddRange(new object[] { "", "Ciabatta", "Focaccia", "Sour Dough", "Rye", "Whole Wheat" });
            cbbBreadFilter.Location = new System.Drawing.Point(86, 24);
            cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2);
            cbbBreadFilter.Name = "cbbBreadFilter";
            cbbBreadFilter.Size = new System.Drawing.Size(256, 28);
            cbbBreadFilter.TabIndex = 4;
            // 
            // btnAddSandwich
            // 
            btnAddSandwich.Location = new System.Drawing.Point(4, 219);
            btnAddSandwich.Margin = new System.Windows.Forms.Padding(2);
            btnAddSandwich.Name = "btnAddSandwich";
            btnAddSandwich.Size = new System.Drawing.Size(337, 29);
            btnAddSandwich.TabIndex = 3;
            btnAddSandwich.Text = "Add new Sandwich";
            btnAddSandwich.UseVisualStyleBackColor = true;
            btnAddSandwich.Click += btnAddSandwich_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(174, 250);
            btnLoad.Margin = new System.Windows.Forms.Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(167, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(4, 250);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(166, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save data";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbxMenu
            // 
            lbxMenu.FormattingEnabled = true;
            lbxMenu.ItemHeight = 20;
            lbxMenu.Location = new System.Drawing.Point(4, 85);
            lbxMenu.Margin = new System.Windows.Forms.Padding(2);
            lbxMenu.Name = "lbxMenu";
            lbxMenu.Size = new System.Drawing.Size(339, 124);
            lbxMenu.TabIndex = 0;
            lbxMenu.SelectedIndexChanged += lbxMenu_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRevenue);
            groupBox2.Controls.Add(btnSell);
            groupBox2.Controls.Add(lblSandwichInfo);
            groupBox2.Location = new System.Drawing.Point(362, 1);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(300, 284);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cart";
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new System.Drawing.Point(4, 250);
            btnRevenue.Margin = new System.Windows.Forms.Padding(2);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new System.Drawing.Size(292, 29);
            btnRevenue.TabIndex = 2;
            btnRevenue.Text = "Show total revenue";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnSell
            // 
            btnSell.Location = new System.Drawing.Point(4, 218);
            btnSell.Margin = new System.Windows.Forms.Padding(2);
            btnSell.Name = "btnSell";
            btnSell.Size = new System.Drawing.Size(292, 29);
            btnSell.TabIndex = 1;
            btnSell.Text = "Sell selected sandwhich";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // lblSandwichInfo
            // 
            lblSandwichInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblSandwichInfo.Location = new System.Drawing.Point(4, 24);
            lblSandwichInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSandwichInfo.Name = "lblSandwichInfo";
            lblSandwichInfo.Size = new System.Drawing.Size(292, 192);
            lblSandwichInfo.TabIndex = 0;
            lblSandwichInfo.Text = "[Sandwich Data]";
            lblSandwichInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(673, 294);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainForm";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblSandwichInfo;
        private System.Windows.Forms.Button btnAddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}