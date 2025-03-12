namespace FinalProject
{
    partial class FavoritesWishlistPage
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
            btnBack = new Button();
            lblFavorites = new Label();
            flpFavorites = new FlowLayoutPanel();
            lblWishlist = new Label();
            flpWishlist = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(929, 648);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFavorites
            // 
            lblFavorites.AutoSize = true;
            lblFavorites.Font = new Font("Cambria", 24F, FontStyle.Bold);
            lblFavorites.ForeColor = Color.FromArgb(255, 78, 67);
            lblFavorites.Location = new Point(12, 27);
            lblFavorites.Name = "lblFavorites";
            lblFavorites.Size = new Size(153, 37);
            lblFavorites.TabIndex = 1;
            lblFavorites.Text = "Favorites";
            // 
            // flpFavorites
            // 
            flpFavorites.AutoScroll = true;
            flpFavorites.Location = new Point(12, 76);
            flpFavorites.Name = "flpFavorites";
            flpFavorites.Size = new Size(992, 255);
            flpFavorites.TabIndex = 2;
            // 
            // lblWishlist
            // 
            lblWishlist.AutoSize = true;
            lblWishlist.Font = new Font("Cambria", 24F, FontStyle.Bold);
            lblWishlist.ForeColor = Color.FromArgb(255, 78, 67);
            lblWishlist.Location = new Point(12, 334);
            lblWishlist.Name = "lblWishlist";
            lblWishlist.Size = new Size(139, 37);
            lblWishlist.TabIndex = 3;
            lblWishlist.Text = "Wishlist";
            // 
            // flpWishlist
            // 
            flpWishlist.AutoScroll = true;
            flpWishlist.Location = new Point(12, 374);
            flpWishlist.Name = "flpWishlist";
            flpWishlist.Size = new Size(992, 268);
            flpWishlist.TabIndex = 3;
            // 
            // FavoritesWishlistPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(1018, 683);
            Controls.Add(flpWishlist);
            Controls.Add(lblWishlist);
            Controls.Add(flpFavorites);
            Controls.Add(lblFavorites);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FavoritesWishlistPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Favorites/Wishlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblFavorites;
        private FlowLayoutPanel flpFavorites;
        private Label lblWishlist;
        private FlowLayoutPanel flpWishlist;
    }
}