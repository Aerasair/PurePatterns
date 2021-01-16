using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    class IronDoor : IDoor
    {
        public void getDescription()
        {
            Console.WriteLine("Я железная дверь");
        }
    }
}
