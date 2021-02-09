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

        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weapon = null;
        }
        public void AttackDino(Dinosaur dinosaur)
        {
            if (powerLevel >= 10)
            {
                Console.WriteLine($"{name} attacks for {weapon.attackPower} damage!");
                dinosaur.health -= weapon.attackPower;
                powerLevel -= 10;
                if (dinosaur.health > 0)
                {
                    Console.WriteLine($"{dinosaur.type} now has {dinosaur.health} health left.");
                }
                else
                {
                    Console.WriteLine($"{dinosaur.type} has fallen!\n");
                }
            }
            else
            {
                Console.WriteLine($"{name} has low power and is recharging its battery.");
                powerLevel += 10;
            }
            
        }
        public void DisplayInfo()
        {
            Console.Write($"{name} has ");

            if (weapon.type[0] == 'A' || weapon.type[0] == 'E' || weapon.type[0] == 'I' || weapon.type[0] == 'O' || weapon.type[0] == 'U')
            {
                Console.Write($"an ");
            }
            else
            {
                Console.Write($"a ");
            }
            Console.Write($"{weapon.type} equipped. \n");
        }


    }
}
