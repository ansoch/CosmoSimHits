using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    abstract class Traits
    {
        public virtual int Weight { get; protected set; } = 0;
        public virtual int Capacity { get; protected set; } = 0;
        public virtual string Name { get; protected set; } = "Item";
    }
    abstract class NonSolidTraits : Traits
    {
        public int WeightCapacityRatio { get; protected set; } = 1;
        public void Transfer(int capacity)
        {

        }
    }
}
