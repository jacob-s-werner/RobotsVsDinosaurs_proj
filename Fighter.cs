﻿using System;
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
                    Console.WriteLine($"{enemyFighter.name} now has {enemyFighter.health} health left.");
                }
                else
                {
                    Console.WriteLine($"{enemyFighter.name} has fallen!\n");
                }
            }
            else
            {
                Console.WriteLine($"{name} has low power and is recharging its battery.");
                energyLevel += energyRechargeRate;
            }
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