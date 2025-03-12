namespace FinalProject
{
    partial class SearchPage
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
            flpMovies = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(33, 26, 25);
            btnBack.Location = new Point(898, 680);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // flpMovies
            // 
            flpMovies.AutoScroll = true;
            flpMovies.Location = new Point(28, 32);
            flpMovies.Name = "flpMovies";
            flpMovies.Size = new Size(928, 618);
            flpMovies.TabIndex = 1;
            // 
            // SearchPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 26, 25);
            ClientSize = new Size(985, 715);
            Controls.Add(flpMovies);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SearchPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private FlowLayoutPanel flpMovies;
    }
}