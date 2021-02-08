using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Herd herd = new Herd();
            Fleet fleet = new Fleet();
            Battlefield battlefield = new Battlefield(herd, fleet);

            Console.WriteLine("Forging Weapons...");
            Weapon plainSword = new Weapon("Sword", 9);
            Weapon plainAxe = new Weapon("Axe", 13);
            Weapon plainGun = new Weapon("Gun", 6);

            Console.WriteLine("Gearing up Robots....");
            Robot robot1 = new Robot("BetZ", 1, plainSword);
            Robot robot2 = new Robot("BarnE", 1, plainAxe);
            Robot robot3 = new Robot("BobE", 1, plainGun);

            Console.WriteLine("Scanning Dinosaurs types...");
            Dinosaur dino1 = new Dinosaur("Pterodactyl", 6);
            Dinosaur dino2 = new Dinosaur("T-Rex", 13);
            Dinosaur dino3 = new Dinosaur("Velociraptor", 9);

            Console.WriteLine("Sending out Fleet...");            
            fleet.PopulateFleet(robot1);
            fleet.PopulateFleet(robot2);
            fleet.PopulateFleet(robot3);

            Console.WriteLine("Reaching rogue Dinosaur Herd proximity....");
            herd.PopulateHerd(dino1);
            herd.PopulateHerd(dino2);
            herd.PopulateHerd(dino3);

            Console.WriteLine($"Starting Battle! \n");
            battlefield.RunBattle();

            Console.WriteLine("\n ----------------END OF PROGRAM-------------");
            Console.ReadLine();

        }
    }
}
