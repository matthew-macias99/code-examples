namespace FinalProject
{
    partial class HomePage
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
            lblWelcome = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            btnViewFavorites = new Button();
            btnAddRemove = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(255, 74, 67);
            lblWelcome.Location = new Point(334, 197);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(242, 57);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Cambria", 26.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(255, 185, 120);
            lblSearch.Location = new Point(242, 254);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(419, 41);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search for a movie or genre";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(226, 311);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(370, 23);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(33, 26, 25);
            btnSearch.Location = new Point(602, 311);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.FromArgb(33, 26, 25);
            btnShowAll.Location = new Point(226, 346);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(117, 49);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnViewFavorites
            // 
            btnViewFavorites.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewFavorites.ForeColor = Color.FromArgb(33, 26, 25);
            btnViewFavorites.Location = new Point(560, 346);
            btnViewFavorites.Name = "btnViewFavorites";
            btnViewFavorites.Size = new Size(117, 49);
            btnViewFavorites.TabIndex = 5;
            btnViewFavorites.Text = "View Favorites/Wishlist";
            btnViewFavorites.UseVisualStyleBackColor = true;
            btnViewFavorites.Click += btnViewFavorites_Click;
            // 
            // btnAddRemove
            // 
            btnAddRemove.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRemove.ForeColor = Color.FromArgb(33, 26, 25);
            btnAddRemove.Location = new Point(394, 346);
            btnAddRemove.Name = "btnAddRemove";
            btnAddRemove.Size = new Size(117, 49);
            btnAddRemove.TabIndex = 6;
            btnAddRemove.Text = "Add/Remove Movie";
            btnAddRemove.UseVisualStyleBackColor = true;
            btnAddRemove.Click += btnAddRemove_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(33, 26, 25);
            btnExit.Location = new Point(808, 660);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(895, 695);
            Controls.Add(btnExit);
            Controls.Add(btnAddRemove);
            Controls.Add(btnViewFavorites);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Database/Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShowAll;
        private Button btnViewFavorites;
        private Button btnAddRemove;
        private Button btnExit;
    }
}
