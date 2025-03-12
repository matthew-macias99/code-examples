namespace FinalProject
{
    partial class AddRemovePage
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
            lblRemoveMOvie = new Label();
            txtRemoveTitle = new TextBox();
            btnRemove = new Button();
            lblAddMovie = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtCast = new TextBox();
            lblCast = new Label();
            txtDirector = new TextBox();
            lblDirector = new Label();
            txtWriter = new TextBox();
            lblWriter = new Label();
            txtProducer = new TextBox();
            lblProducer = new Label();
            txtRating = new TextBox();
            lblRating = new Label();
            dtpReleaseDate = new DateTimePicker();
            lblReleaseDate = new Label();
            txtGenre = new TextBox();
            lblGenre = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtPosterPath = new TextBox();
            lblPosterPath = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(502, 499);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblRemoveMOvie
            // 
            lblRemoveMOvie.AutoSize = true;
            lblRemoveMOvie.Font = new Font("Cambria", 21.75F, FontStyle.Bold);
            lblRemoveMOvie.ForeColor = Color.FromArgb(255, 47, 67);
            lblRemoveMOvie.Location = new Point(27, 30);
            lblRemoveMOvie.Name = "lblRemoveMOvie";
            lblRemoveMOvie.Size = new Size(227, 34);
            lblRemoveMOvie.TabIndex = 1;
            lblRemoveMOvie.Text = "Remove a Movie";
            // 
            // txtRemoveTitle
            // 
            txtRemoveTitle.Location = new Point(27, 67);
            txtRemoveTitle.Name = "txtRemoveTitle";
            txtRemoveTitle.Size = new Size(272, 23);
            txtRemoveTitle.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Cambria", 9F);
            btnRemove.ForeColor = Color.FromArgb(33, 26, 25);
            btnRemove.Location = new Point(321, 66);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblAddMovie
            // 
            lblAddMovie.AutoSize = true;
            lblAddMovie.Font = new Font("Cambria", 21.75F, FontStyle.Bold);
            lblAddMovie.ForeColor = Color.FromArgb(255, 47, 67);
            lblAddMovie.Location = new Point(27, 140);
            lblAddMovie.Name = "lblAddMovie";
            lblAddMovie.Size = new Size(240, 34);
            lblAddMovie.TabIndex = 4;
            lblAddMovie.Text = "Add a New Movie";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 18F);
            lblTitle.ForeColor = Color.FromArgb(255, 185, 120);
            lblTitle.Location = new Point(27, 199);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(96, 199);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 23);
            txtTitle.TabIndex = 6;
            // 
            // txtCast
            // 
            txtCast.Location = new Point(96, 244);
            txtCast.Name = "txtCast";
            txtCast.Size = new Size(203, 23);
            txtCast.TabIndex = 8;
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Font = new Font("Cambria", 18F);
            lblCast.ForeColor = Color.FromArgb(255, 185, 120);
            lblCast.Location = new Point(27, 244);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(62, 28);
            lblCast.TabIndex = 7;
            lblCast.Text = "Cast:";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(150, 298);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(203, 23);
            txtDirector.TabIndex = 10;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Cambria", 18F);
            lblDirector.ForeColor = Color.FromArgb(255, 185, 120);
            lblDirector.Location = new Point(27, 298);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(105, 28);
            lblDirector.TabIndex = 9;
            lblDirector.Text = "Director:";
            // 
            // txtWriter
            // 
            txtWriter.Location = new Point(150, 342);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(203, 23);
            txtWriter.TabIndex = 12;
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Font = new Font("Cambria", 18F);
            lblWriter.ForeColor = Color.FromArgb(255, 185, 120);
            lblWriter.Location = new Point(27, 342);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(86, 28);
            lblWriter.TabIndex = 11;
            lblWriter.Text = "Writer:";
            // 
            // txtProducer
            // 
            txtProducer.Location = new Point(150, 390);
            txtProducer.Name = "txtProducer";
            txtProducer.Size = new Size(203, 23);
            txtProducer.TabIndex = 14;
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Font = new Font("Cambria", 18F);
            lblProducer.ForeColor = Color.FromArgb(255, 185, 120);
            lblProducer.Location = new Point(27, 390);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(114, 28);
            lblProducer.TabIndex = 13;
            lblProducer.Text = "Producer:";
            // 
            // txtRating
            // 
            txtRating.Location = new Point(150, 441);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(203, 23);
            txtRating.TabIndex = 16;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Cambria", 18F);
            lblRating.ForeColor = Color.FromArgb(255, 185, 120);
            lblRating.Location = new Point(27, 441);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(85, 28);
            lblRating.TabIndex = 15;
            lblRating.Text = "Rating:";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReleaseDate.Location = new Point(553, 199);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 22);
            dtpReleaseDate.TabIndex = 17;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Cambria", 18F);
            lblReleaseDate.ForeColor = Color.FromArgb(255, 185, 120);
            lblReleaseDate.Location = new Point(386, 199);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(151, 28);
            lblReleaseDate.TabIndex = 18;
            lblReleaseDate.Text = "Release Date:";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(511, 244);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(203, 23);
            txtGenre.TabIndex = 20;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Cambria", 18F);
            lblGenre.ForeColor = Color.FromArgb(255, 185, 120);
            lblGenre.Location = new Point(388, 244);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(80, 28);
            lblGenre.TabIndex = 19;
            lblGenre.Text = "Genre:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(532, 294);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(390, 109);
            txtDescription.TabIndex = 22;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Cambria", 18F);
            lblDescription.ForeColor = Color.FromArgb(255, 185, 120);
            lblDescription.Location = new Point(386, 294);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 28);
            lblDescription.TabIndex = 21;
            lblDescription.Text = "Description:";
            // 
            // txtPosterPath
            // 
            txtPosterPath.Location = new Point(581, 435);
            txtPosterPath.Name = "txtPosterPath";
            txtPosterPath.Size = new Size(341, 23);
            txtPosterPath.TabIndex = 24;
            // 
            // lblPosterPath
            // 
            lblPosterPath.AutoSize = true;
            lblPosterPath.Font = new Font("Cambria", 18F);
            lblPosterPath.ForeColor = Color.FromArgb(255, 185, 120);
            lblPosterPath.Location = new Point(386, 435);
            lblPosterPath.Name = "lblPosterPath";
            lblPosterPath.Size = new Size(181, 28);
            lblPosterPath.TabIndex = 23;
            lblPosterPath.Text = "Poster File Path:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cambria", 9F);
            btnAdd.ForeColor = Color.FromArgb(33, 26, 25);
            btnAdd.Location = new Point(945, 435);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddRemovePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(1074, 534);
            Controls.Add(btnAdd);
            Controls.Add(txtPosterPath);
            Controls.Add(lblPosterPath);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtGenre);
            Controls.Add(lblGenre);
            Controls.Add(lblReleaseDate);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtRating);
            Controls.Add(lblRating);
            Controls.Add(txtProducer);
            Controls.Add(lblProducer);
            Controls.Add(txtWriter);
            Controls.Add(lblWriter);
            Controls.Add(txtDirector);
            Controls.Add(lblDirector);
            Controls.Add(txtCast);
            Controls.Add(lblCast);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblAddMovie);
            Controls.Add(btnRemove);
            Controls.Add(txtRemoveTitle);
            Controls.Add(lblRemoveMOvie);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddRemovePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add or Remove a Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblRemoveMOvie;
        private TextBox txtRemoveTitle;
        private Button btnRemove;
        private Label lblAddMovie;
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtCast;
        private Label lblCast;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtWriter;
        private Label lblWriter;
        private TextBox txtProducer;
        private Label lblProducer;
        private TextBox txtRating;
        private Label lblRating;
        private DateTimePicker dtpReleaseDate;
        private Label lblReleaseDate;
        private TextBox txtGenre;
        private Label lblGenre;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtPosterPath;
        private Label lblPosterPath;
        private Button btnAdd;
    }
}