using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        string name;
        int health, powerLevel;
        Weapon weapon;

        public Robot(string name, int powerLevel, Weapon weapon)
        {
            this.name = name;
            health = 100;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
    }
}
