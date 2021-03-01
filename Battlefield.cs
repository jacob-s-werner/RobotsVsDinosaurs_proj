using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        public Fleet fleet;
        public Herd herd;
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        public void RunBattle()
        {
            Dinosaur currentDinosaur;
            Robot currentRobot;

            herd.DisplayHerdInfo();

            Console.WriteLine("Prepare to land! [press ENTER]");
            Console.ReadLine();
            Console.WriteLine($"Starting Battle! \n");
            Console.WriteLine($"{fleet.robotInventory[0].name} jumps into battle first!");

            while (herd.dinosaurInventory.Count > 0 && fleet.robotInventory.Count > 0)
            {
                currentDinosaur = herd.dinosaurInventory[0];
                currentRobot = fleet.robotInventory[0];
                BattleRound(currentDinosaur, currentRobot);

                if (currentDinosaur.health <= 0)
                {
                    herd.dinosaurInventory.Remove(currentDinosaur);
                }
                else
                {
                    fleet.robotInventory.Remove(currentRobot);
                }
            }

            if (herd.dinosaurInventory.Count > 0)
            {
                Console.WriteLine("\nThe Dinosaur herd demolished your fleet!");
            }
            else
            {
                Console.WriteLine("\nYour Robot fleet obliterated the herd, congratulations on your promotion!");
            }

            Console.WriteLine("\n----------------END OF BATTLE-------------");
        }
        public void BattleRound(Dinosaur currentDinosaur, Robot currentRobot)
        {
            while (currentRobot.health > 0 || currentDinosaur.health > 0)
            {
                currentRobot.Attack(currentDinosaur);
                if (currentDinosaur.health <= 0)
                {
                    break;
                }
                currentDinosaur.Attack(currentRobot);
                if (currentRobot.health <= 0)
                {
                    break;
                }
            }
        }
    }
}
