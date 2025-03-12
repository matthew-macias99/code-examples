using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Writer { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public string PosterPath { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsWishlist { get; set; }


        public List<Review> Reviews { get; set; } = new List<Review>();

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
    }
}
