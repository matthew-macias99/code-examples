namespace FinalProject
{
    partial class ReviewPage
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
            lblMovieTitle = new Label();
            txtReview = new TextBox();
            btnSaveReview = new Button();
            btnBack = new Button();
            txtRating = new TextBox();
            lblReview = new Label();
            lblYourName = new Label();
            txtReviewerName = new TextBox();
            SuspendLayout();
            // 
            // lblMovieTitle
            // 
            lblMovieTitle.AutoSize = true;
            lblMovieTitle.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieTitle.ForeColor = Color.FromArgb(255, 74, 67);
            lblMovieTitle.Location = new Point(47, 57);
            lblMovieTitle.MaximumSize = new Size(0, 100);
            lblMovieTitle.Name = "lblMovieTitle";
            lblMovieTitle.Size = new Size(455, 37);
            lblMovieTitle.TabIndex = 0;
            lblMovieTitle.Text = "Add Review For (movie name)";
            // 
            // txtReview
            // 
            txtReview.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReview.ForeColor = Color.FromArgb(33, 26, 25);
            txtReview.Location = new Point(47, 116);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(1038, 353);
            txtReview.TabIndex = 1;
            // 
            // btnSaveReview
            // 
            btnSaveReview.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveReview.ForeColor = Color.FromArgb(33, 26, 25);
            btnSaveReview.Location = new Point(47, 593);
            btnSaveReview.Name = "btnSaveReview";
            btnSaveReview.Size = new Size(91, 23);
            btnSaveReview.TabIndex = 2;
            btnSaveReview.Text = "Save Review";
            btnSaveReview.UseVisualStyleBackColor = true;
            btnSaveReview.Click += btnSaveReview_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(1042, 593);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtRating
            // 
            txtRating.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRating.ForeColor = Color.FromArgb(33, 26, 25);
            txtRating.Location = new Point(169, 483);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 22);
            txtRating.TabIndex = 4;
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReview.ForeColor = Color.FromArgb(255, 74, 67);
            lblReview.Location = new Point(47, 472);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(111, 34);
            lblReview.TabIndex = 5;
            lblReview.Text = "Rating:";
            // 
            // lblYourName
            // 
            lblYourName.AutoSize = true;
            lblYourName.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYourName.ForeColor = Color.FromArgb(255, 74, 67);
            lblYourName.Location = new Point(47, 519);
            lblYourName.Name = "lblYourName";
            lblYourName.Size = new Size(168, 34);
            lblYourName.TabIndex = 6;
            lblYourName.Text = "Your Name:";
            // 
            // txtReviewerName
            // 
            txtReviewerName.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReviewerName.ForeColor = Color.FromArgb(33, 26, 25);
            txtReviewerName.Location = new Point(216, 528);
            txtReviewerName.Name = "txtReviewerName";
            txtReviewerName.Size = new Size(160, 22);
            txtReviewerName.TabIndex = 7;
            // 
            // ReviewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(1129, 628);
            Controls.Add(txtReviewerName);
            Controls.Add(lblYourName);
            Controls.Add(lblReview);
            Controls.Add(txtRating);
            Controls.Add(btnBack);
            Controls.Add(btnSaveReview);
            Controls.Add(txtReview);
            Controls.Add(lblMovieTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReviewPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write a Review";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieTitle;
        private TextBox txtReview;
        private Button btnSaveReview;
        private Button btnBack;
        private TextBox txtRating;
        private Label lblReview;
        private Label lblYourName;
        private TextBox txtReviewerName;
    }
}