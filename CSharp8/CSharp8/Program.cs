using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior leviticus = new Warrior("Leviticus", 1000, 120, 40);
            Battle.StartFight(maximus, leviticus);
        }
    }
}
