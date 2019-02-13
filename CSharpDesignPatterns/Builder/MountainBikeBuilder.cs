using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        /* Class object of AbstractRoadBike  is assigned by the constructor and retrieved 
         * by the property Bicycle*/

        private AbstractMountainBike _mountainBikeInProgress;

        /* Property of MountainBikeBuilder used to return an object of IBicycle. This object is of type
         * AbstractRoadBike that implements the IBicycle interface. */

        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }
        }

        /* Constructor of the class MountainBikeBuilder that takes a paramenter of AbstractMountainBike
         * and assigns that parameter to the class field _mountainBikeinProgress. */

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike; // mountainBike is the value assigned to the field

        }

        /* Method
         * public - Access Modifier
         * override - used to define this behavior instead of the parent class that it extends
         * void - no return type */

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires"); /* trying to demonstrate that something is happening 
            at this level. */
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handlebars");
        }
    }
}
