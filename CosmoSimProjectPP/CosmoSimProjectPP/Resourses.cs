using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    interface IResource
    {
        public string ResourceName { get; }
        public void ResourceFeature();
    }

}
