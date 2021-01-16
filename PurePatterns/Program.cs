using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurePatterns.Creational.SimpleFactory;
using PurePatterns.Creational.FabricMethod;

namespace PurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleFactory();
            FabricMethod();


            Console.ReadLine();
        }



        static void SimpleFactory()
        {
            DoorFactory d = new DoorFactory();

            WoodenDoor door = DoorFactory.MakeDoor(100, 200);
            Console.WriteLine(door.width);
            Console.WriteLine(door.height);
        }

        static void FabricMethod()
        {
            DevelopmentManager dev = new DevelopmentManager();
            dev.takeInterview();

            MarketingManager mar = new MarketingManager();
            mar.takeInterview();
        }


    }
}
