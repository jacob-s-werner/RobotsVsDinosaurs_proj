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
        public string[] attackTypes = {"Bites", "Scratches", "Chomps", "Tail Whips"};
        Random random;

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;
            random = new Random();
            
        }
        public void AttackRobot(Robot robot)
        {
            string attackType = attackTypes[random.Next(attackTypes.Length)];
            Console.WriteLine($"{type} {attackType} for {attackPower} damage!");
            robot.health -= attackPower;
            if (robot.health > 0)
            {
                Console.WriteLine($"{robot.name} now has {robot.health} health left.");
            }
            else
            {
                Console.WriteLine($"{robot.name} has broken down! \n");
            }
            
            
        }
    }
}
