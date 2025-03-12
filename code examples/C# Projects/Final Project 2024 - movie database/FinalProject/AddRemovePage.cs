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
    public partial class AddRemovePage : Form
    {
        public AddRemovePage()
        {
            InitializeComponent();
        }

        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        //REMOVE BUTTON
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string movieTitle = txtRemoveTitle.Text.Trim();

            if (string.IsNullOrEmpty(movieTitle))
            {
                MessageBox.Show("Please enter the exact movie title to remove from database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new MovieDBContext())
            {
                var movieToRemove = context.Movies.FirstOrDefault(m => m.Title == movieTitle);

                if (movieToRemove != null)
                {
                    context.Movies.Remove(movieToRemove);
                    context.SaveChanges();
                    MessageBox.Show("Movie removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemoveTitle.Clear();
                }
                else
                {
                    MessageBox.Show("Movie not found. Please verify title is correct and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtCast.Text) || string.IsNullOrEmpty(txtDirector.Text) ||
                string.IsNullOrEmpty(txtWriter.Text) || string.IsNullOrEmpty(txtProducer.Text) || string.IsNullOrEmpty(txtRating.Text) ||
                string.IsNullOrEmpty(txtGenre.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtPosterPath.Text))
            {
                MessageBox.Show("Incomplete Data. Please ensure all fields are filled out correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            if (!double.TryParse(txtRating.Text, out double rating))
            {
                MessageBox.Show("Invalid Rating. Please enter a valid number between 1-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (var context = new MovieDBContext())
            {
                var newMovie = new Movie
                {
                    Title = txtTitle.Text.Trim(),   
                    Cast = txtCast.Text.Trim(),
                    Director = txtDirector.Text.Trim(),
                    Writer = txtWriter.Text.Trim(),
                    Producer = txtProducer.Text.Trim(),
                    Rating = rating,
                    ReleaseDate = dtpReleaseDate.Value,
                    Genre = txtGenre.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    PosterPath = txtPosterPath.Text.Trim()
                };
                context.Movies.Add(newMovie);
                context.SaveChanges();
                MessageBox.Show("Movie added to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitle.Clear();
                txtCast.Clear();
                txtDirector.Clear();
                txtWriter.Clear();
                txtProducer.Clear();
                txtRating.Clear();
                txtGenre.Clear();
                txtDescription.Clear();
                txtPosterPath.Clear();
                dtpReleaseDate.Value = DateTime.Today;

            }
            

            
        }
    }
}
