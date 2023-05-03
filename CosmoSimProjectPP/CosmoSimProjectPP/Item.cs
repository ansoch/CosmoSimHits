using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    interface Item
    {
        public int Weight { get; }
        public int Capacity { get; }
        public string Name { get; }
    }
}
