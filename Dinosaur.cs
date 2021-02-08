using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int health, energy, attackPower;

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;
            
        }
        public void AttackRobot(Robot robot)
        {
            Console.WriteLine($"{type} attacks for {attackPower} damage!");
            robot.health -= attackPower;
            Console.WriteLine($"{robot.name} now has {robot.health} health left.");
        }
    }
}
