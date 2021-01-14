using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.SimpleFactory
{
    class DoorFactory
    {
        public static WoodenDoor MakeDoor(double width, double height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
