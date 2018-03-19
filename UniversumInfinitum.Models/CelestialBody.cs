using System;
using System.Collections.Generic;

namespace UniversumInfinitum.Models
{
    public class CelestialBody
    {
        public string Id { get; set; }

        public string HostId { get; set; }

        public CelestialBodyType Type { get; protected set; }

        public CelestialBodyType HostType { get; protected set; }

        public IEnumerable<CelestialBody> Satellites { get; set; }

        public CelestialBody()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
