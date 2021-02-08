using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        string type;
        int attackPower;


        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }
    }
}
