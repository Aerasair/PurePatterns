using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurePatterns.Creational.FabricMethod
{
    class MarketingManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
