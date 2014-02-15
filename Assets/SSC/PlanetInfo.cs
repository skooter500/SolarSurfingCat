using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSC
{
	public class PlanetInfo
	{
        public string name;
        public float distance; // In Km
        public float period;
        public float incl;
        public float eccen;
        public float radius; // In Km

        public PlanetInfo(string name, float distance, float period, float incl, float eccen, float radius)
        {
            this.name = name;
            this.distance = distance;
            this.period = period;
            this.incl = incl;
            this.eccen = eccen;
            this.radius = radius;
        }

        public PlanetInfo():this("", 0, 0, 0, 0, 0)
        {
        }
    }
}
