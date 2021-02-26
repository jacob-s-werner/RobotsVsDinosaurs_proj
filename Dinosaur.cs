using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur : Fighter
    {
        public string type;
        public int energy, attackPower;
        public string[] attackTypes = {"Bites", "Scratches", "Chomps", "Tail Whips"};
        Random random;
        
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            random = new Random();
        }
        public override void DisplayDeathMessage()
        {
            Console.WriteLine($"{type} has fallen!\n");
        }
        public override void DisplayEnergyLevelRechargeMessage()
        {
            Console.WriteLine($"{type} is exhausted and trying to regain energy!");
        }

    }
}
