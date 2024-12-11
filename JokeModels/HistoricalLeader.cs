using System;
using System.Collections.Generic;

namespace cherry_P20QE5.JokeModels
{
    public partial class HistoricalLeader
    {
        public int LeaderId { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int ReignStart { get; set; }
        public int? ReignEnd { get; set; }
        public bool IsStillAlive { get; set; }
    }
}
