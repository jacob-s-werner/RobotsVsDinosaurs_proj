using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot : Fighter
    {
        public Weapon weapon;
        public int PowerLevel
        {
            get => energyLevel;
            set => energyLevel = value;
        }
        public Robot(string name)
        {
            this.name = name;
            attackEnergyUsage = 10;
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
