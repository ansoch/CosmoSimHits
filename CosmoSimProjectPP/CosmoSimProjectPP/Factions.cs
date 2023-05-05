using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    interface IFaction
    {
        static int Relationship { get; set; }
    }
    class ImperiumFaction : IFaction
    {

    }
    class HiveFaction : IFaction
    {
        
    }
    class RebellionFaction : IFaction
    {

    }
    class NomadFaction : IFaction
    {

    } 
    static class Factions
    {
        public static IFaction Imperium { get; } = new ImperiumFaction();
    }
}
