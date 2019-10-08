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

        public void Attack()
        {
            Random generator = new Random();
            int damage = generator.Next(250, 600);
            

        }

        public void Hurt()
        {

        }


    }
}
