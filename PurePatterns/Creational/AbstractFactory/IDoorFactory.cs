using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.AbstractFactory
{
    public interface IDoorFactory
    {
        IDoor makeDoor();
        IDoorFittingExpert makeFittingExpert();
    }
}
