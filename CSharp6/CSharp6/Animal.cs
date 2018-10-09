using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Animal
    {
        // Only allows class methods to change a variable 
        // protected allows the class as well as any subclasses to change the field
        private string name;
        private string sound;

        // Read only fields will be set at runtime. Provides a way to change only at runtime
        public readonly int idNum;

        // Can not change this at all once defined
        public const string SHELTER = "Luke's Home for Animals";

        private static int numOfAnimals = 0;

        // a constructor that passes defualt values up the chain
        public Animal()
        : this("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 2147483640);
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        // Setters protect the fields from getting bad data
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain number's");
            }
        }

        // Getters allow to format data differently
        public string GetName()
        {
            return name;
        }

        // Another way to make getters and setters through properties
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10) //value is the default var for setter when using properties
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }

        // automatically makes getter and setter for field Owner, default is "No Owner
        public string Owner { get; set; } = "No Owner";

        // using a getter and setter for a static field
        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }

    }
}