using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    class WoodenDoorFactory : IDoorFactory
    {
        public IDoor makeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert makeFittingExpert()
        {
            return new Carpenter();
        }
    }
}
