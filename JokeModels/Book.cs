﻿using System;
using System.Collections.Generic;

namespace cherry_P20QE5.JokeModels
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Year { get; set; }
        public string Genre { get; set; } = null!;
        public bool IsAvailable { get; set; }
    }
}
