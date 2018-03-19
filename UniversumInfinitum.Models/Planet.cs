namespace UniversumInfinitum.Models
{
    public sealed class Planet : CelestialBody
    {
        public PlanetClass Class { get; set; }

        public bool IsHabitable { get; set; }

        public Planet() : base()
        {
            Type = CelestialBodyType.Planet;
        }
    }
}
