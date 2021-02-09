using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        public List<Dinosaur> dinosaurInventory;

        public Herd()
        {
            dinosaurInventory = new List<Dinosaur>();

            Console.WriteLine("Scanning Dinosaurs types...");
            Dinosaur dino1 = new Dinosaur("Pterodactyl", 7);
            Dinosaur dino2 = new Dinosaur("T-Rex", 15);
            Dinosaur dino3 = new Dinosaur("Velociraptor", 10);

            Console.WriteLine("Reaching rogue Dinosaur Herd proximity....");
            PopulateHerd(dino1);
            PopulateHerd(dino2);
            PopulateHerd(dino3);
        }

        public void PopulateHerd(Dinosaur dinosaur)
        {
            dinosaurInventory.Add(dinosaur);
        }
    }
}
