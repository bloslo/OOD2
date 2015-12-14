using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class Splitter : Component
    {
        public Component Input { get; set; }
        public Component UpperOutput { get; set; }
        public Component LowerOutput { get; set; }
    }
}
