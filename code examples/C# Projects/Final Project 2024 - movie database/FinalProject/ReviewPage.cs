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
    public partial class ReviewPage : Form
    {
        private Movie _movie;
        private MoviePage _parentMoviePage;
        public ReviewPage(Movie movie, MoviePage parentMoviePage)
        {
            InitializeComponent();
            _movie = movie;
            _parentMoviePage = parentMoviePage;
            lblMovieTitle.Text = $"Write a Review for \"{_movie.Title}\":";
        }

        //SAVE REVIEW BUTTON
        private void btnSaveReview_Click(object sender, EventArgs e)
        {
            string newReview = txtReview.Text.Trim();
            double rating = double.TryParse(txtRating.Text, out double newRating) ? newRating : 0;

            if (string.IsNullOrWhiteSpace(newReview) || rating <= 0 || rating > 10)
            {
                MessageBox.Show("Please enter a valid review and/or rating (1-10)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string reviewerName = txtReviewerName.Text.Trim();
            if (string.IsNullOrEmpty(reviewerName))
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            using (var context = new MovieDBContext())
            {
                var review = new Review
                {
                    MovieId = _movie.MovieId,
                    Rating = rating,
                    ReviewText = newReview,
                    ReviewerName = reviewerName
                };
                context.Review.Add(review);
                context.SaveChanges();
            }
            MessageBox.Show("Review Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtReview.Clear();
            txtRating.Clear();
            txtReviewerName.Clear();
            _parentMoviePage.Show();
            this.Close();
        }

        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentMoviePage.Show();
            this.Close();
        }
    }
}
