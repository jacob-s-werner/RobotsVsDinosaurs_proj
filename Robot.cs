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

        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            health = 100;
            this.powerLevel = 100;
            this.weapon = weapon;
        }
        public void AttackDino(Dinosaur dinosaur)
        {
            Console.WriteLine($"{name} attacks for {weapon.attackPower} damage!");
            dinosaur.health -= weapon.attackPower;
            if (dinosaur.health > 0)
            {
                Console.WriteLine($"{dinosaur.type} now has {dinosaur.health} health left.");
            }
            else
            {
                Console.WriteLine($"{dinosaur.type} has fallen!");
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
