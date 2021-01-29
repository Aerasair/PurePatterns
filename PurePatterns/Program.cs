using System;
using PurePatterns.Creational.SimpleFactory;
using PurePatterns.Creational.FabricMethod;
using PurePatterns.Creational.AbstractFactory;
using PurePatterns.Creational.Builder;
using PurePatterns.Creational.Prototype;
using PurePatterns.Creational.Singleton;

namespace PurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleFactory();
            // FabricMethod();
            //AbstractFactory();
            // Builder();
            //Prototype();
            CallSingleton();

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

        static void Builder()
        {
            BurgerBuilder burger = new BurgerBuilder(14);
            burger.addPepperoni();
            burger.addLettuce();
            burger.addTomato();
          //  burger.addCheese();
            Console.WriteLine("pepperoni " + burger.pepperoni); 
            Console.WriteLine("lettuce " + burger.lettuce); 
            Console.WriteLine("tomato " + burger.tomato); 
            Console.WriteLine("cheese " + burger.cheese); 
        }

        static void Prototype()
        {
            Person p1 = new Person();
            p1.age = 24;
            p1.birthDate = Convert.ToDateTime("1996-05-04");
            p1.name = "Andrey";
            p1.idInfo = new IdInfo(666);

            Person p2 = p1.ShallowCopy();

            Person p3 = p1.DeepCopy();

            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");

            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p1.name, p1.age, p1.birthDate);
            Console.WriteLine("      ID#: {0:d}", p1.idInfo.idNumber);

            Console.WriteLine("   p2 instance values:");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p2.name, p2.age, p2.birthDate);
            Console.WriteLine("      ID#: {0:d}", p2.idInfo.idNumber);
            Console.WriteLine("   p3 instance values:");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p3.name, p3.age, p3.birthDate);
            Console.WriteLine("      ID#: {0:d}", p3.idInfo.idNumber);

            p1.age = 25;
            p1.birthDate = Convert.ToDateTime("2000-01-01");
            p1.name = "Garen";
            p1.idInfo.idNumber = 8800;

            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p1.name, p1.age, p1.birthDate);
            Console.WriteLine("      ID#: {0:d}", p1.idInfo.idNumber);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p2.name, p2.age, p2.birthDate);
            Console.WriteLine("      ID#: {0:d}", p2.idInfo.idNumber);
            //p3.name = "Jinn";
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p3.name, p3.age, p3.birthDate);
            Console.WriteLine("      ID#: {0:d}", p3.idInfo.idNumber);
        }

        static void CallSingleton()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2) Console.WriteLine("They are two same objects");
            else Console.WriteLine("Singleton doesn't work");
        }

    }
}
