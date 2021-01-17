using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.FabricMethod
{
    class Developer: IInterviewer
    {
        public void askQuestons()
        {
            Console.WriteLine("Ask about programming"); 
        }
    }
}
