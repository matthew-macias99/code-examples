using System.Windows.Forms.VisualStyles;

namespace FinalProject
{
    public partial class HomePage : Form
    {
        private SearchPage _searchPage;
        public HomePage()
        {
            InitializeComponent();
            var allMovies = GetMoviesFromDatabase();
            _searchPage = new SearchPage(allMovies);
        }
        //FETCH THE MOVIES!!!
        private List<Movie> GetMoviesFromDatabase(string searchText = null)
        {
            using (var context = new MovieDBContext())
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    return context.Movies
                        .Where(m => m.Title.Contains(searchText) || m.Genre.Contains(searchText))
                        .ToList();
                }
                return context.Movies.ToList();
            }
        }
        //SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var searchResults = GetMoviesFromDatabase(searchText);

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No Movies found matching your search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                txtSearch.Focus();
                return;
            }

            var searchPage = new SearchPage(searchResults);
            searchPage.Show();
            this.Hide();
        }
        //SHOW ALL BUTTON
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var allMovies = GetMoviesFromDatabase();

            var searchPage = new SearchPage(allMovies);
            searchPage.Show();
            this.Hide();
        }
        //ADD REMOVE BUTTON
        private void btnAddRemove_Click(object sender, EventArgs e)
        {
            var addRemovePage = new AddRemovePage();
            addRemovePage.Show();
            this.Hide();
        }
        //VIEW FAVORITES AND WISHLIST BUTTON
        private void btnViewFavorites_Click(object sender, EventArgs e)
        {
            var favoriteWishlistPage = new FavoritesWishlistPage(_searchPage);
            favoriteWishlistPage.Show();
            this.Hide();
        }
        //EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //enter key as search option
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
