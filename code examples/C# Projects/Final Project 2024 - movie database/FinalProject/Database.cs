using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Database
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public List<Movie> SearchByTitle(string title)
        {
            return Movies.FindAll(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        public List<Movie> SearchByGenre(string genre)
        {
            return Movies.FindAll(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void RemoveMovie(Movie movie)
        {
            Movies.Remove(movie);
        }

        public Movie GetMovieDetails(int movieId)
        {
            return Movies.Find(m => m.MovieId == movieId);
        }
    }
}
