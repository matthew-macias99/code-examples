using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MoviePage : Form
    {
        private Movie _movie;
        private SearchPage _searchPage;
        public MoviePage(Movie movie, SearchPage searchPage)
        {
            InitializeComponent();
            _movie = movie;
            _searchPage = searchPage;
            LoadMovieDetails();
            LoadReview();
        }
        //LOAD MOVIE DETAILS
        private void LoadMovieDetails()
        {
            lblTitle.Text = _movie.Title;
            lblDirector.Text = FormatAsList(_movie.Director);
            lblWriter.Text = FormatAsList(_movie.Writer);
            lblProducer.Text = FormatAsList(_movie.Producer);
            lblGenre.Text = _movie.Genre;
            lblCast.Text = FormatAsList(_movie.Cast);
            lblReleaseDate.Text = _movie.ReleaseDate.ToString("MMMM d, yyyy");
            lblDescription.Text = _movie.Description;
            lblRating.Text = $"{_movie.Rating:0.0}/10";
            pbPoster.ImageLocation = Path.Combine(Application.StartupPath, _movie.PosterPath);
        }
        //LOAD REVIEWS
        private void LoadReview()
        {
            using (var context = new MovieDBContext())
            {
                var reviews = context.Review
                    .Where(r => r.MovieId == _movie.MovieId)
                    .Select(r => $"{r.ReviewerName}: {r.Rating}/10 - {r.ReviewText}")
                    .ToList();

                lbxReviews.Items.Clear();
                foreach (var review in reviews)
                {
                    lbxReviews.Items.Add(review);
                }
            }
        }
        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            _searchPage.Show();
            this.Close();
        }
        //REVIEW BUTTON
        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            var reviewPage = new ReviewPage(_movie, this);
            reviewPage.Show();
            this.Hide();
        }
        //PURCHASE BUTTON
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            var purchasePage = new PurchasePage(_movie, _searchPage);
            purchasePage.Show();
            this.Hide();
        }
        //FAVORITES CHECKBOX
        private void cbxFavorite_CheckChanged(object sender, EventArgs e)
        {
            using (var context = new MovieDBContext())
            {
                var movieToUpdate = context.Movies.FirstOrDefault(m => m.MovieId == _movie.MovieId);
                if (movieToUpdate != null)
                {
                    movieToUpdate.IsFavorite = cbxFavorite.Checked;
                    context.SaveChanges();
                }
            }
        }
        //WISHLIST CHECKBOX
        private void cbxWishlist_CheckChanged(Object sender, EventArgs e)
        {
            using (var context = new MovieDBContext())
            {
                var movieToUpdate = context.Movies.FirstOrDefault(m => m.MovieId == _movie.MovieId);
                if (movieToUpdate != null)
                {
                    movieToUpdate.IsWishlist = cbxWishlist.Checked;
                    context.SaveChanges();
                }
            }
        }
        //LIST FORMATTING 
        private string FormatAsList(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "N/A";
            var items = input.Split(',').Select(items => items.Trim());
            return string.Join(Environment.NewLine, items);
        }

    }
}
