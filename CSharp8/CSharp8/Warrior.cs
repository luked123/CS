using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    class Warrior
    {
        // Name, Health, Attack, Maximum, Block Maximum
        private string name;
        private int health;
        private int attackMax;
        private int blockMax;


        // Simple constructor using properties
        public Warrior(string name, int health, int attackMax, int blockMax)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(Char.IsDigit))
                {
                    name = "No name";
                    Console.WriteLine("Name cannot contain digits");
                }
                else { name = value; }
            }
        }

        
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 9999)
                {
                    Console.WriteLine("Health cannot be less than 0 or more than 9999");
                    health = 0;
                }
                else { health = value; } 
            }
        }


        private int AttackMax
        {
            get { return attackMax; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Maximum value for attack cannot be less than 0");
                    attackMax = 0;
                }
                else{ attackMax = value;}
            }
        }

        private int BlockMax
        {
            get { return blockMax; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Maximum value for defense cannot be less than 0");
                    blockMax = 0;
                }
                else { blockMax = value; }
            }
        }

        Random rnd = new Random(); // create one instance of random object as it is proned to repeating values otherwise

        // Attack 
        // generate a random attack form 1 to the maximum attack
        public int Attack()
        {
            return rnd.Next(1, AttackMax);
        }

        // Block
        // Generate a random block from 1 
        // to the maximum block
        public int Block()
        {
            return rnd.Next(1,blockMax);
        }
    }
}
