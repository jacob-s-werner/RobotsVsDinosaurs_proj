using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fighter
    {
        public string name;
        public int health, energyLevel, attackEnergyUsage, attackDamageGiven;

        public Fighter()
        {
            health = 100;
            energyLevel = 100;
        }
    }
}
