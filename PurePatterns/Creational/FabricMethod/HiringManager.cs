using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.FabricMethod
{
    abstract class HiringManager
    {
        public abstract  IInterviewer makeInterviewer();

        public void takeInterview()
        {
            var interviewer = makeInterviewer();
            interviewer.askQuestons();
        }
    }
}
