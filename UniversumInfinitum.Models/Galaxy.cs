using System.Collections.Generic;

namespace UniversumInfinitum.Models
{
    public sealed class Galaxy
    {
        IEnumerable<GalaxyTile> Tiles { get; set; }

        public int Radius { get; set; }

        public float CoreSize { get; set; }

        public Galaxy()
        {
            Tiles = new List<GalaxyTile>();
            Radius = 500;
            CoreSize = 0.1f;
        }
    }
}
