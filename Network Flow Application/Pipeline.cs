using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class Pipeline
    {
        public double SafetyLimit { get; set; }
        public double CurrentFlow { get; set; }
        public Component Input { get; set; }
        public Component Output { get; set; }
    }
}
