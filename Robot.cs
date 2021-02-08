using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        public string name;
        public int health, powerLevel;
        public Weapon weapon;

        public Robot(string name, int powerLevel, Weapon weapon)
        {
            this.name = name;
            health = 100;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
        public void AttackDino(Dinosaur dino)
        {
            Console.WriteLine($"{name} attacks for {weapon.attackPower} damage!");
            dino.health -= weapon.attackPower;
            Console.WriteLine($"{dino.type} now has {dino.health} health left.");
        }


    }
}
