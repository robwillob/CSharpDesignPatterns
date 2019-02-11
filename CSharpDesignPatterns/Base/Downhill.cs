using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns

{
    public class Downhil : AbstractRoadBike
    {

        public Downhill(IWheel wheel)
           : this(BikeColor.Green, wheel)
        {

        }

        public Downhill(BikeColor color, IWheel wheel)
            : base(color, wheel) { }
    }
}