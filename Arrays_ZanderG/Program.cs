using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_ZanderG
{
    internal class Program
    {
        static string[] weaponNames = { "Pistol", "AK47", "Minigun", "Bazooka" };
        static int[] ammo = { 5, 10, 20, 1 };
        static int[] maxAmmo = { 5, 10, 20, 1 };
        static int[] weaponDamage = { 1, 3, 5, 10 };
        static int[] weaponRate = { 1, 5, 10, 1 };

        static string currentWeapon = weaponNames[0];

        static void Main(string[] args)
        {
            ShowHUD();
            Console.WriteLine("Press enter to fire");
            Console.ReadKey();
            Console.Clear();
            Fire(currentWeapon);
            
            ShowHUD();
            Console.WriteLine($"Your weapon delt {weaponDamage[0]} damage");
            Console.WriteLine("Press enter to reload");
            Console.ReadKey();
            Console.Clear();
            Reload(currentWeapon);

            currentWeapon = weaponNames[1];
            ShowHUD();
            Console.WriteLine($"You now have a {weaponNames[1]}");
            Console.WriteLine("Press enter to fire");
            Console.ReadKey();
            Console.Clear();
            Fire(currentWeapon);

            ShowHUD();
            Console.WriteLine($"Your weapon delt {weaponDamage[1]} damage");
            Console.WriteLine("Press enter to reload");
            Console.ReadKey();
            Console.Clear();
            Reload(currentWeapon);

            currentWeapon = weaponNames[2];
            ShowHUD();
            Console.WriteLine($"You now have a {weaponNames[2]}");
            Console.WriteLine("Press enter to fire");
            Console.ReadKey();
            Console.Clear();
            Fire(currentWeapon);

            ShowHUD();
            Console.WriteLine($"Your weapon delt {weaponDamage[2]} damage");
            Console.WriteLine("Press enter to reload");
            Console.ReadKey();
            Console.Clear();
            Reload(currentWeapon);

            currentWeapon = weaponNames[3];
            ShowHUD();
            Console.WriteLine($"You now have a {weaponNames[3]}");
            Console.WriteLine("Press enter to fire");
            Console.ReadKey();
            Console.Clear();
            Fire(currentWeapon);

            ShowHUD();
            Console.WriteLine($"Your weapon delt {weaponDamage[3]} damage");
            Console.WriteLine("Press enter to reload");
            Console.ReadKey();
            Console.Clear();
            Reload(currentWeapon);

            ShowHUD();
        }

        static void ShowHUD()
        {
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}{4,10}", "Weapon", " Pistol Ammo", " AK47 Ammo", " Minigun Ammo", " Bazooka Ammo");
            Console.WriteLine("{0,0}{1,10}{2,10}{3,10}{4,10}", currentWeapon, ammo[0], ammo[1], ammo[2], ammo[3]);
        }

        static void Fire(string currentGun)
        {
            int indexOfWeapons = Array.IndexOf(weaponNames, currentGun);

            if (ammo[indexOfWeapons] == 0)
            {

            }
            else
            {
                ammo[indexOfWeapons] -= weaponRate[indexOfWeapons];
            }
        }

        static void Reload(string currentGun)
        {
            int indexOfWeapons = Array.IndexOf(weaponNames, currentGun);

            ammo[indexOfWeapons] = maxAmmo[indexOfWeapons];
        }
    }
}
