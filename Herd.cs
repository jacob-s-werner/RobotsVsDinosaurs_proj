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
        }

        public void PopulateHerd(Dinosaur dino)
        {
            dinosaurInventory.Add(dino);
        }
    }
}
