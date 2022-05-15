using System;

namespace Weapon_class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletcapacity;
            int bulletcount;
            bool check = true;

            do
            {
                Console.WriteLine("Enter Bulletcapacity:");

                bulletcapacity = Convert.ToInt32(Console.ReadLine());
            } while (bulletcapacity < 0 || bulletcapacity == 0);


            do
            {
                Console.WriteLine("Enter Bulletcount:");
                bulletcount = Convert.ToInt32(Console.ReadLine());

            } while (bulletcount < 0 || bulletcount>bulletcapacity || bulletcount == 0);

            Weapon weapon = new Weapon(bulletcapacity,bulletcount);

            weapon.Bulletcount = bulletcapacity;
            weapon.Bulletcount = bulletcount;

            do
            {
                Console.WriteLine("0: İnformasiya almaq üçün");
                Console.WriteLine("1: Shoot metodu üçün");
                Console.WriteLine("2: Fire metodu üçün");
                Console.WriteLine("3: GetRemainBulletCount metodu üçün");
                Console.WriteLine("4: Reload metodu üçün");
                Console.WriteLine("5: ChangeFireMode metodu üçün");
                Console.WriteLine("6: Proqramdan dayandırmaq üçün");

                switch (Console.ReadLine())
                {
                    case "0":
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFire();
                        break;
                    case "6":
                        check = false;
                        break;
                    default:
                        break;
                }

            } while (check);
        }
    }
}
