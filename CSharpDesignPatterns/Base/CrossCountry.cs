using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns

{
    public class CrossCountry : AbstractRoadBike
    {

        public CrossCountry(IWheel wheel)
           : this(BikeColor.Pink, wheel)
        {

        }

        public CrossCountry(BikeColor color, IWheel wheel)
            : base(color, wheel) { }
    }
}
