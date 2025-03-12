using System.IO;
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
    public partial class FavoritesWishlistPage : Form
    {
        private MovieDBContext _context;
        private SearchPage _searchPage;
        public FavoritesWishlistPage(SearchPage searchPage)
        {
            InitializeComponent();
            _context = new MovieDBContext();
            _searchPage = searchPage;
            LoadFavorites();
            LoadWishlist();
        }

        //LOAD FAVORITES
        private void LoadFavorites()
        {
            flpFavorites.Controls.Clear();
            var favoriteMovies = _context.Movies.Where(m => m.IsFavorite).ToList();
            foreach(var movie in favoriteMovies)
            {
                var panel = new FlowLayoutPanel
                {
                    Width = 170,
                    Height = 250,
                    FlowDirection = FlowDirection.TopDown,
                    Padding = new Padding(5)
                };

                var pbPoster = new PictureBox
                {
                    ImageLocation = Path.Combine(Application.StartupPath, movie.PosterPath),
                    Width = 150,
                    Height = 200,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
                };

                pbPoster.Click += (sender, e) =>
                {
                    var moviePage = new MoviePage(movie, _searchPage);
                    moviePage.Show();
                    this.Hide();
                };
                var btnRemove = new Button
                {
                    Text = "Remove",
                    Width = 150,
                    ForeColor = Color.FromArgb(255,185,120)
                };
                btnRemove.Click += (sender, e) =>
                {
                    RemoveFromFavorites(movie.MovieId);
                    LoadFavorites();
                };
                panel.Controls.Add(pbPoster);
                panel.Controls.Add(btnRemove);
                flpFavorites.Controls.Add(panel);
            }
        }
        //LOAD WISHLIST
        private void LoadWishlist()
        {
            flpWishlist.Controls.Clear();
            var wishlistMovies = _context.Movies.Where(m =>m.IsWishlist).ToList();
            foreach (var movie in wishlistMovies)
            {
                var panel = new FlowLayoutPanel
                {
                    Width = 170,
                    Height = 250,
                    FlowDirection = FlowDirection.TopDown,
                    Padding = new Padding(5)
                };

                var pbPoster = new PictureBox
                {
                    ImageLocation = Path.Combine(Application.StartupPath, movie.PosterPath),
                    Width = 150,
                    Height = 200,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
                };

                pbPoster.Click += (sender, e) =>
                {
                    var purchasePage = new PurchasePage(movie, _searchPage);
                    purchasePage.Show();
                    this.Hide();
                };

                var btnRemove = new Button
                {
                    Text = "Remove",
                    Width = 150,
                    ForeColor = Color.FromArgb(255, 185, 120)
                };
                btnRemove.Click += (sender, e) =>
                {
                    RemoveFromWishlist(movie.MovieId);
                    LoadWishlist();
                };

                panel.Controls.Add(pbPoster);
                panel.Controls.Add(btnRemove);
                flpWishlist.Controls.Add(panel);
            }
            
        }

        //REMOVE FAVORITE
        private void RemoveFromFavorites(int movieId)
        {
            using (var context = new MovieDBContext())
            {
                var movie = context.Movies.FirstOrDefault(m => m.MovieId == movieId); 
                if (movie != null)
                {
                    movie.IsFavorite = false;
                    context.SaveChanges();
                }
            }
        }

        //REMOVE FROM WISHLIST
        private void RemoveFromWishlist(int movieId)
        {
            using (var context = new MovieDBContext())
            {
                var movie = context.Movies.FirstOrDefault(m => m.MovieId == movieId);
                if (movie != null)
                {
                    movie.IsWishlist = false;
                    context.SaveChanges();
                }
            }
        }

        //BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();  
            homePage.Show();
            this.Close();
        }
    }
}
