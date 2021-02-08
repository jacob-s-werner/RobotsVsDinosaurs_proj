using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        Herd herd;
        Fleet fleet;

        public Battlefield(Herd herd, Fleet fleet)
        {
            this.herd = herd;
            this.fleet = fleet;


        }
        public void RunBattle()
        {
            Dinosaur currentDinosaur;
            Robot currentRobot;

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
                Console.WriteLine("The Dinosaur herd demolished your fleet!");
            }
            else
            {
                Console.WriteLine("Your Robot fleet obliterated the herd, congratulations on your promotion!");
            }
            
        }
        public void BattleRound(Dinosaur currentDinosaur, Robot currentRobot)
        {
            while (currentRobot.health > 0 || currentDinosaur.health > 0)
            {
                currentRobot.AttackDino(currentDinosaur);
                if (currentDinosaur.health <= 0)
                {
                    break;
                }
                currentDinosaur.AttackRobot(currentRobot);
                if (currentRobot.health <= 0)
                {
                    break;
                }
            }
        }
        


    }
    
}
