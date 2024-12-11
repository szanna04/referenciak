using System;
using System.Collections.Generic;

namespace cherry_P20QE5.JokeModels
{
    public partial class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; } = null!;
        public int ReleaseYear { get; set; }
        public string Genre { get; set; } = null!;
        public bool IsAvailable { get; set; }
    }
}
