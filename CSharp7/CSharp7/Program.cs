/* Luke Donnelly
 * C# Pt 7
 * Covers Inheritance, Delegates, Super Classes, Polymorphism
 * Virtual, Override, Inner Classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };

            grover.Sound = "Wooof"; //can change this directly because it was named as protected

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeee"
            };

            // polymorphism 
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooofff",
                Sound2 = "Gerrrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();


            Console.ReadLine();
        }
    }
}

