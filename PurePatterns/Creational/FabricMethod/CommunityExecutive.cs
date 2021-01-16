using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.FabricMethod
{
    class CommunityExecutive: IInterviewer
    {
        public void askQuestons()
        {
            Console.WriteLine("Спрашивает о работе с сообществом");
        }
    }
}
