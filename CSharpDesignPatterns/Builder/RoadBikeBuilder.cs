using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
   public class RoadBikeBuilder : BikeBuilder
    {
        /* Class object of AbstractRoadBike  is assigned by the constructor and retrieved 
         * by the property Bicycle*/

        private AbstractRoadBike _roadBikeInProgress;

        /* Property of RoadBikeBuilder used to return an object of IBicycle. This object is of type
         * AbstractRoadBike that implements the IBicycle interface. */

        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }
        }

        /* Constructor of the class RoadBikeBuilder that takes a paramenter of AbstractRoadBike
         * and assigns that parameter to the class field _roadBikeinProgress. */

        public RoadBikeBuilder(AbstractRoadBike roadBike) 
        {
            this._roadBikeInProgress = roadBike; // roadBike is the value assigned to the field

        }

        /* Method
         * public - Access Modifier
         * override - used to define this behavior instead of the parent class that it extends
         * void - no return type */
          
        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Steet Tires"); /* trying to demonstrate that something is happening 
            at this level. */
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building Roadike Handlebars");
        }
    }
}
