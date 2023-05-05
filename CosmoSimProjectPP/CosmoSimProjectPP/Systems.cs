using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    class PlanetSystem
    {
        public Planet[] PlanetList { get; }
        public Planet[] StationList { get; }
    }
    class Planet
    {
        public Satellite[] Satellites { get; }
    }
    class Satellite
    {
        public Planet Planet { get; }
    }
    class Star
    {
        public string StarName { get; }
    }
}
