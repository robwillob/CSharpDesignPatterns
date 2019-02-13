using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        { 


            BuilderPatternDemo();
            // AbstractFactoryDemo();
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.Chrome, new WideWheel(24));

           BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);

        }

        private static void AbstractFactoryDemo()
        {
            /* Parent class object instance is created by its child class. 
             * This parent class can only see methods that it created, that its child uses. 
             * Any child types created, unless it was first created by the parent.*/

            AbstractBikeFactory factory = new RoadBikeFactory(); //used child object instance w/abstract parent

            /* Create the Bike parts
             * Interface object is created. The factory objects created above calls the method that returns the
             interface that it is assigned to. These Created methods created a new object of a Frame or Seat.
             This object can be of either Road or Mountain. In this case the RoadFrame and RoadSeat.*/

            // Interface Object  =  Object calling Constructor CreateBikeFrame from RoadBikeFactory

            IBikeFrame bikeFrame = factory.CreateBikeFrame();

            // CreateBikeSeat method of factory object @returns IBikeSeat to object bikeSeat
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //Show what we created.
            /* Interface object bikeFrame calls the property BikeFrameParts
             * bikeFrame was created from the class RoadFrame. The property BikeFrameParts uses the get to
             * retur the string value from RoadFrame.*/

            Console.WriteLine(bikeFrame.BikeFrameParts);

            /* Interface object bikeSeat calls the property BikeSeatParts
             * bikeSeat was created from the class RoadSeat. The property BikeSeatParts uses the get to
             * return the string value from RoadSeat.*/

            Console.WriteLine(bikeSeat.BikeSeatParts);


        }
    }
}
