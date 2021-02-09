using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        public List<Robot> robotInventory;
        public List<Weapon> weaponInventory;
        Random random;

        public Fleet()
        {
            robotInventory = new List<Robot>();
            weaponInventory = new List<Weapon>();
            random = new Random();

            Console.WriteLine("Forging Weapons...");
            Weapon plainSword = new Weapon("Sword", 9);
            Weapon plainAxe = new Weapon("Axe", 13);
            Weapon plainGun = new Weapon("Gun", 7);
            Weapon plainLance = new Weapon("Lance", 8);
            Weapon plainMace = new Weapon("Mace", 10);

            PopulateWeaponInventory(plainSword);
            PopulateWeaponInventory(plainAxe);
            PopulateWeaponInventory(plainGun);
            PopulateWeaponInventory(plainLance);
            PopulateWeaponInventory(plainMace);

            Console.WriteLine("Gearing up Robots....");
            Robot robot1 = new Robot("BetZ");
            robot1.weapon = WeaponMenu(robot1);
            Robot robot2 = new Robot("BarnE");
            robot2.weapon = WeaponMenu(robot2);
            Robot robot3 = new Robot("BobE");
            robot3.weapon = WeaponMenu(robot3);

            robot1.DisplayInfo();
            robot2.DisplayInfo();
            robot3.DisplayInfo();

            Console.WriteLine("Sending out Fleet...");
            PopulateFleet(robot1);
            PopulateFleet(robot2);
            PopulateFleet(robot3);
        }

        public void PopulateFleet(Robot robot)
        {
            robotInventory.Add(robot);
        }
        public void PopulateWeaponInventory(Weapon weapon)
        {
            weaponInventory.Add(weapon);
        }
        public Weapon AssignRandomWeapon()
        {
            Weapon weapon = weaponInventory[random.Next(weaponInventory.Count)];
            return weapon;
        }
        public Weapon WeaponMenu(Robot robot)
        {
            bool isValid = false;
            int userInput;

            while (isValid == false)
            {
                Console.WriteLine($"Enter the number to equip that weapon for {robot.name}");
                for (int i = 0; i < weaponInventory.Count - 1; i++)
                {
                    Console.WriteLine($"{i + 1}: {weaponInventory[i].type}");
                }
                Console.WriteLine($"{weaponInventory.Count + 1 }: Random");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput >= 1 && userInput <= weaponInventory.Count)
                {
                    Console.WriteLine($"You chose {weaponInventory[userInput - 1].type} for {robot.name}");
                    return weaponInventory[userInput - 1];
                }
                else if (userInput == weaponInventory.Count + 1)
                {
                    Weapon randomWeapon = AssignRandomWeapon();
                    Console.WriteLine($"{robot.name}, using their own random algorithm, chose {randomWeapon.type}");
                    return randomWeapon;
                }
                else
                {
                    Console.WriteLine("Invalid Option, please enter a correct value");
                }
            }

            // needs an option outside of while loop
            return null;
        }
    }
}
