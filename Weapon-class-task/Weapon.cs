using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_class_task
{
    internal class Weapon
    {

        public bool isAutomatic;

        public Weapon(int bulletcapacity, int bulletcount)
        {
            Bulletcapacity = bulletcapacity;
            Bulletcount = bulletcount;
        }


        private int _bulletcapacity;
        public int Bulletcapacity { 
            get 
            {
                return _bulletcapacity;

            }
            set
            {
                if (value>0)
                {
                    _bulletcapacity = value;
                }
            }
        }

        private int _bulletcount;


        public int Bulletcount { 
            get 
            {
                return _bulletcount;
            } 
            set 
            {
                if (value>0)
                {
                    _bulletcount = value;
                }
            } 
        }


        public void Shoot()
        {
            if (Bulletcount>0)
            {
                Console.WriteLine(--Bulletcount);
            }
            else
            {
                Console.WriteLine("Gulle yoxdur");
            }
        }


        public void Fire()
        {
            if (Bulletcount>0)
            {
                if (isAutomatic)
                {
                    Console.WriteLine(Bulletcapacity = 0);
                }
                else
                {
                    Console.WriteLine(--Bulletcount);
                }
            }
        }


        public int GetRemainBulletCount()
        {
            if (Bulletcapacity != Bulletcount)
            {
                return Bulletcapacity - Bulletcount;
            }
            return Bulletcount;
        }

        public void Reload()
        {
            int count;
            if (Bulletcount != Bulletcapacity)
            {
                count = Bulletcapacity - Bulletcount;
                Bulletcount += count;
                Console.WriteLine(Bulletcount);
            }
            else
            {
                Console.WriteLine("Do not Reload");
            }
        }


        public void ChangeFire()
        {
            if (isAutomatic == true)
            {
                isAutomatic = false;

                Console.WriteLine("Firemode" + isAutomatic);
            }
            else
            {
                isAutomatic = true;
                Console.WriteLine("Firemode" + isAutomatic);
            }
        }








    }
}
