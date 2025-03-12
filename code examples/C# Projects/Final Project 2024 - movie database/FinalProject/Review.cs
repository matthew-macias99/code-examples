using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int MovieId { get; set; }
        public double Rating { get; set; }
        public string ReviewText { get; set; }
        public string ReviewerName { get; set; }    

        public Movie Movie { get; set; }

    }
}
