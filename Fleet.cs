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
            Weapon plainGun = new Weapon("Gun", 5);
            Weapon plainLance = new Weapon("Lance", 7);
            Weapon plainMace = new Weapon("Mace", 10);

            PopulateWeaponInventory(plainSword);
            PopulateWeaponInventory(plainAxe);
            PopulateWeaponInventory(plainGun);
            PopulateWeaponInventory(plainLance);
            PopulateWeaponInventory(plainMace);

            Console.WriteLine("Gearing up Robots....");
            Robot robot1 = new Robot("BetZ", 1, AssignRandomWeapon());
            Robot robot2 = new Robot("BarnE", 1, AssignRandomWeapon());
            Robot robot3 = new Robot("BobE", 1, AssignRandomWeapon());

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
            Weapon weapon = weaponInventory[random.Next(weaponInventory.Count - 1)];
            return weapon;
        }
    }
}
