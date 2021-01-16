using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    class IronDoorFactory : IDoorFactory
    {
        public IDoor makeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert makeFittingExpert()
        {
            return new Welder();
        }
    }
}
