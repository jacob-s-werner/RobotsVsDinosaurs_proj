using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fighter
    {
        public string name;
        public int health, energyLevel, attackEnergyUsage, attackDamageGiven, energyRechargeRate;

        public Fighter()
        {
            health = 100;
            energyLevel = 100;
        }
        public void Attack(Fighter enemyFighter)
        {
            if (energyLevel >= attackEnergyUsage)
            {
                Console.WriteLine($"{name} attacks for {attackDamageGiven} damage!");
                enemyFighter.health -= attackDamageGiven;
                energyLevel -= attackEnergyUsage;
                if (enemyFighter.health > 0)
                {
                    enemyFighter.DisplayCurrentHealth();
                }
                else
                {
                    enemyFighter.DisplayDeathMessage();
                }
            }
            else
            {
                enemyFighter.DisplayEnergyLevelRechargeMessage();
                energyLevel += energyRechargeRate;
            }
        }
        public void DisplayCurrentHealth()
        {
            Console.WriteLine($"{name} has {health} health left.");
        }
        public virtual void DisplayDeathMessage()
        {
            Console.WriteLine($"{name} has exploded!\n");
        }
        public virtual void DisplayEnergyLevelRechargeMessage()
        {
            Console.WriteLine($"{name} has low power and is recharging its battery.");
        }
    }
    //        ___                         
    //       |+ +|                 
    // ______|{=}|______                 
    //{                 }        
    // |               |            
    // |               |          
    // |               |            
    // |**|         |**|                               
    //     |   |   |            
    //     |   |   |                               
    //     |   |   |            
    //    _|   |   |_
    //  [_____ | _____]
}
