using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class AdjustableSplitter : Splitter
    {
        public double PercentageUpper { get; set; }
        public double PercentageLower { get; set; }
    }
}
