using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.SimpleFactory
{
    class WoodenDoor : IDOOR
    {
        public double width { get; set; }
        public double height { get; set; }

        public WoodenDoor(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public double GetWidth()
        { 
            return this.width;
        }
    }
}
