using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    class Carpenter : IDoorFittingExpert
    {
        public void getDescription()
        {
            Console.WriteLine("Я работаю только с деревянными дверьми");
        }
    }
}
