using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurePatterns.Creational.SimpleFactory;
using PurePatterns.Creational.FabricMethod;
using PurePatterns.Creational.AbstractFactory;

namespace PurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleFactory();
            //  FabricMethod();
            AbstractFactory();



            Console.ReadLine();
        }



        static void SimpleFactory()
        {
            DoorFactory d = new DoorFactory();

            Creational.SimpleFactory.WoodenDoor door = DoorFactory.MakeDoor(100, 200);//resolving class name conflicts with adding namespace
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

        static void AbstractFactory()
        {
            WoodenDoorFactory woodenDoorFactory = new WoodenDoorFactory();

            var door = woodenDoorFactory.makeDoor();
            var expert = woodenDoorFactory.makeFittingExpert();

            door.getDescription();
            expert.getDescription();



            IronDoorFactory ironDoorFactory = new IronDoorFactory();

            var door2 = ironDoorFactory.makeDoor();
            var expert2 = ironDoorFactory.makeFittingExpert();

            door2.getDescription();
            expert2.getDescription();            
        }

    }
}
