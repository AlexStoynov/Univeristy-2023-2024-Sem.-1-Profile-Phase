namespace BikeTrip
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
            transportationTypeCBB = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            TripRating = new NumericUpDown();
            TripDistance = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddTripBtn = new Button();
            TripDestinationTb = new TextBox();
            groupBox2 = new GroupBox();
            DeleteSelectedTripBtn = new Button();
            ShowInfoSelectedBtn = new Button();
            groupBox3 = new GroupBox();
            FilterTrips = new Button();
            label8 = new Label();
            label7 = new Label();
            FilterRatingMaxVal = new NumericUpDown();
            FilterRatingMinVal = new NumericUpDown();
            label5 = new Label();
            TripsListBox = new ListBox();
            SearchBtn = new Button();
            ShowAllTripsBtn = new Button();
            DestinationSearch = new TextBox();
            ShowAvgBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TripRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TripDistance).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilterRatingMaxVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilterRatingMinVal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(transportationTypeCBB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TripRating);
            groupBox1.Controls.Add(TripDistance);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AddTripBtn);
            groupBox1.Controls.Add(TripDestinationTb);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Trip";
            // 
            // transportationTypeCBB
            // 
            transportationTypeCBB.FormattingEnabled = true;
            transportationTypeCBB.Items.AddRange(new object[] { "BICYCLE", "CAR", "TRAIN", "BUS" });
            transportationTypeCBB.Location = new Point(184, 215);
            transportationTypeCBB.Name = "transportationTypeCBB";
            transportationTypeCBB.Size = new Size(175, 40);
            transportationTypeCBB.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 218);
            label6.Name = "label6";
            label6.Size = new Size(172, 32);
            label6.TabIndex = 8;
            label6.Text = "Transportation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 101);
            label4.Name = "label4";
            label4.Size = new Size(50, 32);
            label4.TabIndex = 7;
            label4.Text = "KM";
            // 
            // TripRating
            // 
            TripRating.DecimalPlaces = 1;
            TripRating.Location = new Point(146, 154);
            TripRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            TripRating.Name = "TripRating";
            TripRating.Size = new Size(213, 39);
            TripRating.TabIndex = 6;
            // 
            // TripDistance
            // 
            TripDistance.DecimalPlaces = 3;
            TripDistance.Location = new Point(146, 99);
            TripDistance.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            TripDistance.Name = "TripDistance";
            TripDistance.Size = new Size(150, 39);
            TripDistance.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 156);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "Rating:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 3;
            label2.Text = "Distance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 2;
            label1.Text = "To:";
            // 
            // AddTripBtn
            // 
            AddTripBtn.Location = new Point(6, 266);
            AddTripBtn.Name = "AddTripBtn";
            AddTripBtn.Size = new Size(353, 46);
            AddTripBtn.TabIndex = 1;
            AddTripBtn.Text = "Add";
            AddTripBtn.UseVisualStyleBackColor = true;
            AddTripBtn.Click += AddTripBtn_Click;
            // 
            // TripDestinationTb
            // 
            TripDestinationTb.Location = new Point(146, 45);
            TripDestinationTb.Name = "TripDestinationTb";
            TripDestinationTb.Size = new Size(213, 39);
            TripDestinationTb.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DeleteSelectedTripBtn);
            groupBox2.Controls.Add(ShowInfoSelectedBtn);
            groupBox2.Location = new Point(12, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 163);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Trip";
            // 
            // DeleteSelectedTripBtn
            // 
            DeleteSelectedTripBtn.Location = new Point(6, 90);
            DeleteSelectedTripBtn.Name = "DeleteSelectedTripBtn";
            DeleteSelectedTripBtn.Size = new Size(353, 46);
            DeleteSelectedTripBtn.TabIndex = 1;
            DeleteSelectedTripBtn.Text = "Delete selected trip";
            DeleteSelectedTripBtn.UseVisualStyleBackColor = true;
            DeleteSelectedTripBtn.Click += DeleteSelectedTripBtn_Click;
            // 
            // ShowInfoSelectedBtn
            // 
            ShowInfoSelectedBtn.Location = new Point(6, 38);
            ShowInfoSelectedBtn.Name = "ShowInfoSelectedBtn";
            ShowInfoSelectedBtn.Size = new Size(353, 46);
            ShowInfoSelectedBtn.TabIndex = 0;
            ShowInfoSelectedBtn.Text = "Show info of selected trip";
            ShowInfoSelectedBtn.UseVisualStyleBackColor = true;
            ShowInfoSelectedBtn.Click += ShowInfoSelectedBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(FilterTrips);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(FilterRatingMaxVal);
            groupBox3.Controls.Add(FilterRatingMinVal);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TripsListBox);
            groupBox3.Controls.Add(SearchBtn);
            groupBox3.Controls.Add(ShowAllTripsBtn);
            groupBox3.Controls.Add(DestinationSearch);
            groupBox3.Location = new Point(445, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(534, 629);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "My Trips";
            // 
            // FilterTrips
            // 
            FilterTrips.Location = new Point(16, 568);
            FilterTrips.Name = "FilterTrips";
            FilterTrips.Size = new Size(504, 46);
            FilterTrips.TabIndex = 3;
            FilterTrips.Text = "Filter trips";
            FilterTrips.UseVisualStyleBackColor = true;
            FilterTrips.Click += FilterTrips_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(373, 523);
            label8.Name = "label8";
            label8.Size = new Size(41, 32);
            label8.TabIndex = 9;
            label8.Text = "to:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 523);
            label7.Name = "label7";
            label7.Size = new Size(228, 32);
            label7.TabIndex = 8;
            label7.Text = "Trips by rating from:";
            // 
            // FilterRatingMaxVal
            // 
            FilterRatingMaxVal.DecimalPlaces = 1;
            FilterRatingMaxVal.Location = new Point(420, 521);
            FilterRatingMaxVal.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            FilterRatingMaxVal.Name = "FilterRatingMaxVal";
            FilterRatingMaxVal.Size = new Size(100, 39);
            FilterRatingMaxVal.TabIndex = 7;
            // 
            // FilterRatingMinVal
            // 
            FilterRatingMinVal.DecimalPlaces = 1;
            FilterRatingMinVal.Location = new Point(267, 521);
            FilterRatingMinVal.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            FilterRatingMinVal.Name = "FilterRatingMinVal";
            FilterRatingMinVal.Size = new Size(100, 39);
            FilterRatingMinVal.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 463);
            label5.Name = "label5";
            label5.Size = new Size(44, 32);
            label5.TabIndex = 4;
            label5.Text = "To:";
            // 
            // TripsListBox
            // 
            TripsListBox.FormattingEnabled = true;
            TripsListBox.HorizontalScrollbar = true;
            TripsListBox.ItemHeight = 32;
            TripsListBox.Location = new Point(16, 38);
            TripsListBox.MultiColumn = true;
            TripsListBox.Name = "TripsListBox";
            TripsListBox.ScrollAlwaysVisible = true;
            TripsListBox.Size = new Size(518, 324);
            TripsListBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(320, 456);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(200, 46);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ShowAllTripsBtn
            // 
            ShowAllTripsBtn.Location = new Point(16, 393);
            ShowAllTripsBtn.Name = "ShowAllTripsBtn";
            ShowAllTripsBtn.Size = new Size(504, 46);
            ShowAllTripsBtn.TabIndex = 1;
            ShowAllTripsBtn.Text = "Show all";
            ShowAllTripsBtn.UseVisualStyleBackColor = true;
            ShowAllTripsBtn.Click += ShowAllTripsBtn_Click;
            // 
            // DestinationSearch
            // 
            DestinationSearch.Location = new Point(71, 460);
            DestinationSearch.Name = "DestinationSearch";
            DestinationSearch.Size = new Size(224, 39);
            DestinationSearch.TabIndex = 0;
            // 
            // ShowAvgBtn
            // 
            ShowAvgBtn.Location = new Point(18, 557);
            ShowAvgBtn.Name = "ShowAvgBtn";
            ShowAvgBtn.Size = new Size(353, 46);
            ShowAvgBtn.TabIndex = 5;
            ShowAvgBtn.Text = "Show average";
            ShowAvgBtn.UseVisualStyleBackColor = true;
            ShowAvgBtn.Click += ShowAvgBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 652);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ShowAvgBtn);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TripRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)TripDistance).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FilterRatingMaxVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilterRatingMinVal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AddTripBtn;
        private TextBox TripDestinationTb;
        private GroupBox groupBox2;
        private Button DeleteSelectedTripBtn;
        private Button ShowInfoSelectedBtn;
        private GroupBox groupBox3;
        private Button SearchBtn;
        private Button ShowAllTripsBtn;
        private TextBox DestinationSearch;
        private Label label4;
        private NumericUpDown TripRating;
        private NumericUpDown TripDistance;
        private ListBox TripsListBox;
        private Label label5;
        private ComboBox transportationTypeCBB;
        private Label label6;
        private Button ShowAvgBtn;
        private NumericUpDown FilterRatingMaxVal;
        private NumericUpDown FilterRatingMinVal;
        private Button FilterTrips;
        private Label label8;
        private Label label7;
    }
}