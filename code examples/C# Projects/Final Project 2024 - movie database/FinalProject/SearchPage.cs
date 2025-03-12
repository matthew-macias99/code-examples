using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SearchPage : Form
    {
        private List<Movie> _movies;
        public SearchPage(List<Movie> movies)
        {
            InitializeComponent();
            _movies = movies;
            PopulateMovies(_movies);
        }

        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
        //POPULATE MOVIE LIST AND POSTERS
        private void PopulateMovies(List<Movie> movies)
        {
            flpMovies.Controls.Clear();

            foreach (var movie in movies)
            {
                var moviePanel = new Panel
                {
                    Width = 250,
                    Height = 350,
                    Margin = new Padding(20),
                    AutoScroll = false
                };
                var lblTitle = new Label
                {
                    Text = movie.Title,
                    AutoSize = false,
                    Width = 200,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(255,185,120),
                    Font = new Font("Cambria", 10, FontStyle.Bold),
                    Dock = DockStyle.Top
                };
                moviePanel.Controls.Add(lblTitle);

                var spacer = new Label
                {
                    Height = 10,
                    Dock = DockStyle.Top
                };
                moviePanel.Controls.Add(spacer);

                var pbPoster = new PictureBox
                {
                    ImageLocation = Path.Combine(Application.StartupPath, movie.PosterPath),
                    Width = 185,
                    Height = 300,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand,
                    Dock = DockStyle.Top
                };
                pbPoster.Click += (sender, e) =>
                {
                    var moviePage = new MoviePage(movie, this);
                    moviePage.Show();
                    this.Hide();
                };
                moviePanel.Controls.Add(pbPoster);
                flpMovies.Controls.Add(moviePanel);
            }
        }
        //ERROR MESSAGE
        private void ShowErrorMessage()
        {
            MessageBox.Show("No movies found matching your search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
