using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; //we need access to this namespace

namespace Builder
{
    public abstract class BikeBuilder
    {
        // Property of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        // Methods below:
        /* Virtual keyword used to optionally override in child class 
         void means no return type.  Builds are method names. */
        public virtual void BuildStreetTires() { }

        public virtual void BuildWideTires() { }

        public virtual void BuildHandleBars() { }


    }
}
