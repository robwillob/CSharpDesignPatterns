using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public abstract class BikeDirector
    {
        /* Interface IBicycle Build is name of Method(parameters BikeBuilder with builder being 
         * the value or variable name */
       public abstract IBicycle Build(BikeBuilder builder);
    }
}
