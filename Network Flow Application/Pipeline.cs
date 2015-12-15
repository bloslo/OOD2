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

        ///<summary>
        ///returns the current flow of the component or pipeline 
        ///</summary>
        ///<returns> current flow</returns>
        public double DisplayFlow(Pipeline p){
            return p.CurrentFlow;
        }



    }
}
