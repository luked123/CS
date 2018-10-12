using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    class Battle
    {
        // StartFight
        // WarriorA Warrior B
        // Loop giving each warrior a chance to attack and block each turn intil 1 
        // dies

        public static void StartFight(Warrior a, Warrior b)
        {
            Console.WriteLine("The fight has begun!");
            while(a.Health > 0 && b.Health > 0)
            {
                if(a.Health > 0)
                {
                    GetAttackResult(a, b);
                }

                if(b.Health > 0)
                {
                    GetAttackResult(b, a);
                }
            }
        }

        // GetAttackResult
        // Warrior A, Warrior B

        private static void GetAttackResult(Warrior a, Warrior b)
        {
            int attack = a.Attack();
            int block = b.Block();

            if(attack > block)
            {
                int dmg = attack - block;
                b.Health = b.Health - dmg;
                Console.WriteLine("{0} attacked {1} for {2} points of damage!", a.Name, b.Name, dmg);
                Console.WriteLine("{0} has {1} health remaining", b.Name, b.Health); 
            }
            else
            {
                Console.WriteLine("{0} completely blocked {1}'s attack!", b.Name, a.Name);
            }

            if(b.Health <= 0)
            {
                Console.WriteLine("{0} has died", b.Name); 
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        // Calculate 1 warriors attack and the others block

        //Subtract block from attack 

        // If there was damage subtract that from the health

        // Pritn out info on who attacked who and for how much damage

        // Provide output on the change in health

        // Check if the warriors health fell below 0 and if so print a message and then
        // send a response that will end the loop
    }
}
