using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    interface IResource
    {
        public void ResourceFeature();
        public Type? ContainerType { get; }
    }
    class FoodResource : NonSolidTraits, IResource
    {
        public void ResourceFeature()
        {

        }
        public Type? ContainerType { get; } = new Box().GetType();
    }
    class OilResource : NonSolidTraits, IResource 
    {
        public void ResourceFeature()
        {

        }
        public Type? ContainerType { get; } = new Barrel().GetType();
    }
    class GasResource : NonSolidTraits, IResource 
    {
        public void ResourceFeature()
        {

        }
        public Type? ContainerType { get; } = new GasChamber().GetType();
    }
    class MineralResource : NonSolidTraits, IResource, IItem 
    {
        public void ResourceFeature()
        {

        }
        public Type? ContainerType { get; } = null;
    }
}
