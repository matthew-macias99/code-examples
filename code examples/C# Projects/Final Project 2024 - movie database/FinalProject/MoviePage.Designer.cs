namespace FinalProject
{
    partial class MoviePage
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
            lblTitle = new Label();
            pbPoster = new PictureBox();
            lblDescription = new Label();
            lblCast = new Label();
            lblDirector = new Label();
            lblWriter = new Label();
            lblProducer = new Label();
            lblRating = new Label();
            lblReleaseDate = new Label();
            lblGenre = new Label();
            cbxFavorite = new CheckBox();
            cbxWishlist = new CheckBox();
            btnBack = new Button();
            btnWriteReview = new Button();
            btnPurchase = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbxReviews = new ListBox();
            lblReviews = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 185, 120);
            lblTitle.Location = new Point(37, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "title";
            // 
            // pbPoster
            // 
            pbPoster.Location = new Point(37, 96);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(360, 542);
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPoster.TabIndex = 1;
            pbPoster.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Cambria", 14.25F);
            lblDescription.ForeColor = Color.FromArgb(255, 185, 120);
            lblDescription.Location = new Point(505, 102);
            lblDescription.MaximumSize = new Size(700, 250);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 22);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "description";
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Font = new Font("Cambria", 14.25F);
            lblCast.ForeColor = Color.FromArgb(255, 185, 120);
            lblCast.Location = new Point(505, 227);
            lblCast.MaximumSize = new Size(200, 200);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(41, 22);
            lblCast.TabIndex = 3;
            lblCast.Text = "cast";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Cambria", 14.25F);
            lblDirector.ForeColor = Color.FromArgb(255, 185, 120);
            lblDirector.Location = new Point(505, 374);
            lblDirector.MaximumSize = new Size(200, 200);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(75, 22);
            lblDirector.TabIndex = 4;
            lblDirector.Text = "director";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Font = new Font("Cambria", 14.25F);
            lblWriter.ForeColor = Color.FromArgb(255, 185, 120);
            lblWriter.Location = new Point(699, 225);
            lblWriter.MaximumSize = new Size(200, 200);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(61, 22);
            lblWriter.TabIndex = 5;
            lblWriter.Text = "writer";
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Font = new Font("Cambria", 14.25F);
            lblProducer.ForeColor = Color.FromArgb(255, 185, 120);
            lblProducer.Location = new Point(699, 372);
            lblProducer.MaximumSize = new Size(200, 200);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(86, 22);
            lblProducer.TabIndex = 6;
            lblProducer.Text = "producer";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Cambria", 14.25F);
            lblRating.ForeColor = Color.FromArgb(255, 185, 120);
            lblRating.Location = new Point(910, 226);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(58, 22);
            lblRating.TabIndex = 7;
            lblRating.Text = "rating";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Cambria", 14.25F);
            lblReleaseDate.ForeColor = Color.FromArgb(255, 185, 120);
            lblReleaseDate.Location = new Point(910, 289);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(106, 22);
            lblReleaseDate.TabIndex = 8;
            lblReleaseDate.Text = "release date";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Cambria", 14.25F);
            lblGenre.ForeColor = Color.FromArgb(255, 185, 120);
            lblGenre.Location = new Point(908, 371);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(56, 22);
            lblGenre.TabIndex = 9;
            lblGenre.Text = "genre";
            // 
            // cbxFavorite
            // 
            cbxFavorite.AutoSize = true;
            cbxFavorite.Font = new Font("Cambria", 14.25F);
            cbxFavorite.ForeColor = Color.FromArgb(255, 185, 120);
            cbxFavorite.Location = new Point(37, 661);
            cbxFavorite.Name = "cbxFavorite";
            cbxFavorite.Size = new Size(161, 26);
            cbxFavorite.TabIndex = 11;
            cbxFavorite.Text = "Add to Favorites";
            cbxFavorite.UseVisualStyleBackColor = true;
            cbxFavorite.CheckedChanged += cbxFavorite_CheckChanged;
            // 
            // cbxWishlist
            // 
            cbxWishlist.AutoSize = true;
            cbxWishlist.Font = new Font("Cambria", 14.25F);
            cbxWishlist.ForeColor = Color.FromArgb(255, 185, 120);
            cbxWishlist.Location = new Point(37, 686);
            cbxWishlist.Name = "cbxWishlist";
            cbxWishlist.Size = new Size(152, 26);
            cbxWishlist.TabIndex = 12;
            cbxWishlist.Text = "Add to Wishlist";
            cbxWishlist.UseVisualStyleBackColor = true;
            cbxWishlist.CheckedChanged += cbxWishlist_CheckChanged;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(1175, 699);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnWriteReview
            // 
            btnWriteReview.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWriteReview.ForeColor = Color.FromArgb(33, 26, 25);
            btnWriteReview.Location = new Point(505, 670);
            btnWriteReview.Name = "btnWriteReview";
            btnWriteReview.Size = new Size(101, 23);
            btnWriteReview.TabIndex = 14;
            btnWriteReview.Text = "Write Review";
            btnWriteReview.UseVisualStyleBackColor = true;
            btnWriteReview.Click += btnWriteReview_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.FromArgb(33, 26, 25);
            btnPurchase.Location = new Point(296, 644);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(101, 23);
            btnPurchase.TabIndex = 15;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 74, 67);
            label1.Location = new Point(505, 77);
            label1.MaximumSize = new Size(400, 200);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 16;
            label1.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 74, 67);
            label2.Location = new Point(505, 202);
            label2.MaximumSize = new Size(150, 200);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 17;
            label2.Text = "Cast:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 74, 67);
            label3.Location = new Point(505, 349);
            label3.MaximumSize = new Size(150, 200);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 18;
            label3.Text = "Director:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 74, 67);
            label4.Location = new Point(909, 201);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 19;
            label4.Text = "Rating:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 74, 67);
            label5.Location = new Point(699, 201);
            label5.MaximumSize = new Size(150, 200);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 20;
            label5.Text = "Writer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 74, 67);
            label6.Location = new Point(909, 265);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 21;
            label6.Text = "Release Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 74, 67);
            label7.Location = new Point(699, 348);
            label7.MaximumSize = new Size(150, 200);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 22;
            label7.Text = "Producer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 74, 67);
            label8.Location = new Point(909, 348);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 23;
            label8.Text = "Genre:";
            // 
            // lbxReviews
            // 
            lbxReviews.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxReviews.ForeColor = Color.FromArgb(33, 26, 25);
            lbxReviews.FormattingEnabled = true;
            lbxReviews.HorizontalScrollbar = true;
            lbxReviews.ItemHeight = 19;
            lbxReviews.Location = new Point(505, 536);
            lbxReviews.Name = "lbxReviews";
            lbxReviews.Size = new Size(546, 99);
            lbxReviews.TabIndex = 24;
            // 
            // lblReviews
            // 
            lblReviews.AutoSize = true;
            lblReviews.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReviews.ForeColor = Color.FromArgb(255, 74, 67);
            lblReviews.Location = new Point(499, 498);
            lblReviews.MaximumSize = new Size(150, 200);
            lblReviews.Name = "lblReviews";
            lblReviews.Size = new Size(124, 32);
            lblReviews.TabIndex = 25;
            lblReviews.Text = "Reviews:";
            // 
            // MoviePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(1262, 734);
            Controls.Add(lblReviews);
            Controls.Add(lbxReviews);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPurchase);
            Controls.Add(btnWriteReview);
            Controls.Add(btnBack);
            Controls.Add(cbxWishlist);
            Controls.Add(cbxFavorite);
            Controls.Add(lblGenre);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblRating);
            Controls.Add(lblProducer);
            Controls.Add(lblWriter);
            Controls.Add(lblDirector);
            Controls.Add(lblCast);
            Controls.Add(lblDescription);
            Controls.Add(pbPoster);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MoviePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Info";
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pbPoster;
        private Label lblDescription;
        private Label lblCast;
        private Label lblDirector;
        private Label lblWriter;
        private Label lblProducer;
        private Label lblRating;
        private Label lblReleaseDate;
        private Label lblGenre;
        private CheckBox cbxFavorite;
        private CheckBox cbxWishlist;
        private Button btnBack;
        private Button btnWriteReview;
        private Button btnPurchase;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox lbxReviews;
        private Label lblReviews;
    }
}