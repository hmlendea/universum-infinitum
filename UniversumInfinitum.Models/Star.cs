namespace UniversumInfinitum.Models
{
    public sealed class Star : CelestialBody
    {
        public PlanetClass Class { get; set; }

        public Star() : base()
        {
            Type = CelestialBodyType.Planet;
        }
    }
}
