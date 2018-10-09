using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    // inheirets from super class Animal using :
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrr"; // automatically creates getters and setters


        // way to override method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}"); // string interpolation using properties
        }

        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            : base(name, sound)             // Use base to let the superclass handle the construstor for name and sound
        {
            Sound2 = sound2;
        }
    }
}