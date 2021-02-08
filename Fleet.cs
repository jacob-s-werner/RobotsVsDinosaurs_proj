using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        public List<Robot> robotInventory;

        public Fleet()
        {
            robotInventory = new List<Robot>();
        }

        public void PopulateFleet(Robot robot)
        {
            robotInventory.Add(robot);
        }
    }
}
