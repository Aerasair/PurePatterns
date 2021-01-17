using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    class Welder : IDoorFittingExpert
    {
        public void getDescription()
        {
            Console.WriteLine("I work with iron doors only");
        }
    }
}
