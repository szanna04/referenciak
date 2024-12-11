using System;
using System.Collections.Generic;

namespace cherry_P20QE5.JokeModels
{
    public partial class ColorsAndMeaning
    {
        public int ColorId { get; set; }
        public string Color { get; set; } = null!;
        public string Culture { get; set; } = null!;
        public string Meaning { get; set; } = null!;
        public bool IsPositive { get; set; }
    }
}
