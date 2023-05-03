using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    abstract class PlanetSystem
    {
        public List<Planet> PlanetList { get; }
    }
    abstract class Planet
    {
        public List<Satellite> Satellites { get; } = new List<Satellite>();
    }
    abstract class Satellite
    {
        public Planet Planet { get; }
    }
    abstract class Star
    {
        public abstract string StarName { get; }
    }
}
