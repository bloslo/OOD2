using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class Component
    {
        public string Name{get;set;}
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double CurrentFlow { get; set; }

        public Component(double x, double y)
        { 
        }

        ///<summary>
        ///returns the current flow of the component or pipeline 
        ///</summary>
        ///<returns> current flow</returns>
        public double DisplayFlow(Component c){
            return c.CurrentFlow;
        }

        /// <summary>
        ///returns the component present at the certain position of the field
        ///if no component is present, returns 'null'
        /// </summary>
        /// <param name="X"
        /// <param name= "y" , the spot position of the component</param>
        /// <returns>returns the component</returns>
        public Component getComponent(int X, int Y)
        { 

            //get a list of components from the network class, if available then return found component
            return null;
        }


    }
}
