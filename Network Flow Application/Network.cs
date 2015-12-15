using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Flow_Application
{
    class Network
    {
        public int FreeSpots { get; set; }

        private List<Component> componentsOnNetwork = new List<Component>();

        ///<summary>
        ///add component to the network
        ///</summary>
        ///<param name = “x” Indicates the X coordinates for position on the spot></param>
        ///<param name = “y” Indicates the Y coordinates for position on the spot></param>
        ///<returns> component </returns>
        public Component AddComponent(double x, double y)
        {
            Component c = new Component(x, y);
            componentsOnNetwork.Add(c);
            return c;
        }

        ///<summary>
        ///remove a component from the network
        ///</summary>
        ///<param name = “component”  The class of type component: splitter, merger, etc.  ></param>
        public void RemoveComponent(Component c)
        {
            componentsOnNetwork.Remove(c);
        }

        public List<Component> ListFreeSpots()
        {

            return componentsOnNetwork;
            
        }


    }
}
