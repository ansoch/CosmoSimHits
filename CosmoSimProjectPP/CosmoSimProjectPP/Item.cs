using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    interface IItem
    {
        public int Weight { get; }
        public int Capacity { get; }
        public string Name { get; }

    }
    abstract class Container : IItem
    {
        public int Weight { get; protected set; }

        public int Capacity { get; protected set; }

        public string Name { get; }
        protected IResource Resource{ get; }
        virtual public void Fill(Container withdrawalContainer, int amount)
        {

        }
        virtual public void Withdraw(Container fillingContainer, int amount) 
        {
            
        }
    }
    class Box : Container
    {

    }
    class Barrel : Container
    {

    }
    class GasChamber : Container
    {

    }
}
