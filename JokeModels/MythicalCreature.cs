using System;
using System.Collections.Generic;

namespace cherry_P20QE5.JokeModels
{
    public partial class MythicalCreature
    {
        public int CreatureId { get; set; }
        public string Name { get; set; } = null!;
        public string Origin { get; set; } = null!;
        public string Type { get; set; } = null!;
        public bool IsFriendly { get; set; }
        public string Description { get; set; } = null!;
    }
}
