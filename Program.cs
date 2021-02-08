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
            
            Weapon plainSword = new Weapon("Sword", 9);
            Weapon plainAxe = new Weapon("Axe", 13);
            Weapon plainGun = new Weapon("Gun", 6);

            Robot robot1 = new Robot("Betsy", 1, plainSword);
            Robot robot2 = new Robot("Barney", 1, plainAxe);
            Robot robot3 = new Robot("Bobby", 1, plainGun);

            Dinosaur dino1 = new Dinosaur("Pterodactyl", 6);
            Dinosaur dino2 = new Dinosaur("T-Rex", 13);
            Dinosaur dino3 = new Dinosaur("Velociraptor", 9);

            herd.PopulateHerd(dino1);
            herd.PopulateHerd(dino2);
            herd.PopulateHerd(dino3);

            fleet.PopulateFleet(robot1);
            fleet.PopulateFleet(robot2);
            fleet.PopulateFleet(robot3);


        }
    }
}
