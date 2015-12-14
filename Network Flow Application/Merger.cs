using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class Merger : Component
    {
        public Component UpperInput { get; set; }
        public Component LowerIntput { get; set; }
        public Component Output { get; set; }
    }
}
