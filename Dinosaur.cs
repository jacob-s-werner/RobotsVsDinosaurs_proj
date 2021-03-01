using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur : Fighter
    {
        public string[] attackTypes = {"Bites", "Scratches", "Chomps", "Tail Whips"};
        public string Type
        {
            get => name;
            set => name = value;
        }
        public int AttackPower
        {
            get => attackDamageGiven;
            set => attackDamageGiven = value;
        }
        public int Energy
        {
            get => energyLevel;
            set => energyLevel = value;
        }
        public Dinosaur(string type, int attackPower)
        {
            name = type;
            attackDamageGiven = attackPower;
            attackEnergyUsage = 10;
        }
        public override void DisplayDeathMessage()
        {
            Console.WriteLine($"{Type} has fallen!\n");
        }
        public override void DisplayEnergyLevelRechargeMessage()
        {
            Console.WriteLine($"{Type} is exhausted and trying to regain energy!");
        }

    }
}
