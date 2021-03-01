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
        public List<Dinosaur> listOfDinosaurOptions;

        public Random random;
        public Herd()
        {
            random = new Random();
            dinosaurInventory = new List<Dinosaur>();
            listOfDinosaurOptions = new List<Dinosaur>();

            Console.WriteLine("Scanning Dinosaurs types...");
            Dinosaur dinosaur1 = new Dinosaur("Pterodactyl", 6);
            PopulateDinosaurOptions(dinosaur1);
            Dinosaur dinosaur2 = new Dinosaur("T-Rex", 15);
            PopulateDinosaurOptions(dinosaur2);
            Dinosaur dinosaur3 = new Dinosaur("Velociraptor", 9);
            PopulateDinosaurOptions(dinosaur3);
            Dinosaur dinosaur4 = new Dinosaur("Stegosaurus", 10);
            PopulateDinosaurOptions(dinosaur4);
            Dinosaur dinosaur5 = new Dinosaur("Triceratops", 12);
            PopulateDinosaurOptions(dinosaur5);
            Dinosaur dinosaur6 = new Dinosaur("Parasaurus", 4);
            PopulateDinosaurOptions(dinosaur6);

            Console.WriteLine("Reaching rogue Dinosaur Herd proximity....");
            
            PopulateHerdRandomly(3);
        }

        public void PopulateHerd(Dinosaur dinosaur)
        {
            dinosaurInventory.Add(dinosaur);
            listOfDinosaurOptions.Remove(dinosaur);
        }
        public void PopulateHerdRandomly(int numberOfDinosaursToAdd)
        {
            Dinosaur dinosaurPicked;
            for (int i = 0; i < numberOfDinosaursToAdd; i++)
            {
                dinosaurPicked = listOfDinosaurOptions[random.Next(listOfDinosaurOptions.Count)];
                dinosaurInventory.Add(dinosaurPicked);
                listOfDinosaurOptions.Remove(dinosaurPicked);
            }
        }
        public void PopulateDinosaurOptions(Dinosaur dinosaur)
        {
            listOfDinosaurOptions.Add(dinosaur);
        }
        public void DisplayHerdInfo()
        {
            foreach (Dinosaur dinosaur in dinosaurInventory)
            {
                if (dinosaur != dinosaurInventory[0] && dinosaur != dinosaurInventory[dinosaurInventory.Count - 1])
                {
                    Console.Write("a ");
                }
                else if (dinosaur == dinosaurInventory[0])
                {
                    Console.WriteLine($"The herd has a {dinosaur.Type}");
                }
                
            }
        }
    }
}
