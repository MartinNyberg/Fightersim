using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightersimulator
{
    class Fighter
    {
        private int hp = 1000;

        public string name = "";

        public string GiveName()
        {
            name = Console.ReadLine();
            Console.WriteLine("Du gav namnet " + name);

            return name;
        }
            

        public int Attack()
        {
            Random generator = new Random();
            int damage = generator.Next(250, 600);

            return damage;
        }

        public void Hurt(int amount)
        {
            hp = hp - amount;
            Console.WriteLine(name + " tog " + amount + " skada.");
            if (hp < 0)
            {
                hp = 0;
            }

        }

        public int GetHp()
        {
            Console.WriteLine(name + " har nu " + hp + "hp kvar.");

            return hp;
        }

        public bool isAlive()
        {
            bool alive = false;

            if (hp >= 1)
            {
                alive = true;
            }

            return alive;
        }


    }
}
