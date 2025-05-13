using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingMovies
{
    internal class Movie
    {
        public string MovieName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? Duration { get; set; } // in minutes
        public double? Rating { get; set; }
        public double? MetaScore { get; set; }
        public int? Votes { get; set; }
        public double? Gross { get; set; }
    }
}
