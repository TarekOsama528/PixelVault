﻿namespace PixelVaultGUI
{
    partial class BrowseTournaments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            LiveTournamentsDataGrid = new DataGridView();
            label1 = new Label();
            ExitButton = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            SortBy = new GroupBox();
            checkedListBox3 = new CheckedListBox();
            BrowseGamesButton = new Button();
            button1 = new Button();
            SearchSpecificTournamentButton = new TextBox();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LiveTournamentsDataGrid).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SortBy.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SearchSpecificTournamentButton);
            panel3.Controls.Add(LiveTournamentsDataGrid);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 322);
            panel3.TabIndex = 2;
            // 
            // LiveTournamentsDataGrid
            // 
            LiveTournamentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LiveTournamentsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            LiveTournamentsDataGrid.GridColor = Color.Black;
            LiveTournamentsDataGrid.Location = new Point(24, 59);
            LiveTournamentsDataGrid.Name = "LiveTournamentsDataGrid";
            LiveTournamentsDataGrid.RowHeadersWidth = 51;
            LiveTournamentsDataGrid.Size = new Size(922, 236);
            LiveTournamentsDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 0;
            label1.Text = "Live Tournaments";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(976, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BrowseGamesButton);
            panel1.Controls.Add(SortBy);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 241);
            panel1.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox2.Controls.Add(checkedListBox2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(230, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Region";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox2.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "North America", "South America", "Europe", "Asia", "Africa" });
            checkedListBox2.Location = new Point(16, 33);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(145, 125);
            checkedListBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(27, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 170);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Sports", "Racing", "Fighting", "Battle Royale", "FPS" });
            checkedListBox1.Location = new Point(16, 33);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(129, 125);
            checkedListBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(177, 31);
            label2.TabIndex = 1;
            label2.Text = "Filter Results By";
            // 
            // SortBy
            // 
            SortBy.BackgroundImage = Properties.Resources.dark_purple_colour;
            SortBy.Controls.Add(checkedListBox3);
            SortBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SortBy.ForeColor = SystemColors.ButtonFace;
            SortBy.Location = new Point(440, 99);
            SortBy.Name = "SortBy";
            SortBy.Size = new Size(167, 121);
            SortBy.TabIndex = 4;
            SortBy.TabStop = false;
            SortBy.Text = "Sort By";
            // 
            // checkedListBox3
            // 
            checkedListBox3.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox3.BorderStyle = BorderStyle.None;
            checkedListBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox3.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Available Spots", "Start Date", "Prize Money" });
            checkedListBox3.Location = new Point(16, 33);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(145, 75);
            checkedListBox3.TabIndex = 0;
            // 
            // BrowseGamesButton
            // 
            BrowseGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            BrowseGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseGamesButton.Location = new Point(672, 62);
            BrowseGamesButton.Name = "BrowseGamesButton";
            BrowseGamesButton.Size = new Size(221, 44);
            BrowseGamesButton.TabIndex = 22;
            BrowseGamesButton.Text = "Filter";
            BrowseGamesButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 186, 212);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(672, 142);
            button1.Name = "button1";
            button1.Size = new Size(221, 44);
            button1.TabIndex = 23;
            button1.Text = "Enroll";
            button1.UseVisualStyleBackColor = false;
            // 
            // SearchSpecificTournamentButton
            // 
            SearchSpecificTournamentButton.Location = new Point(625, 17);
            SearchSpecificTournamentButton.Name = "SearchSpecificTournamentButton";
            SearchSpecificTournamentButton.Size = new Size(314, 27);
            SearchSpecificTournamentButton.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(558, 20);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 3;
            label3.Text = "Search";
            // 
            // BrowseTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(panel1);
            Controls.Add(ExitButton);
            Controls.Add(panel3);
            Name = "BrowseTournaments";
            Size = new Size(1011, 653);
            Load += BrowseTournaments_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LiveTournamentsDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            SortBy.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private DataGridView LiveTournamentsDataGrid;
        private Label label1;
        private Label ExitButton;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox2;
        private GroupBox SortBy;
        private CheckedListBox checkedListBox3;
        private Button button1;
        private Button BrowseGamesButton;
        private Label label3;
        private TextBox SearchSpecificTournamentButton;
    }
}