/* Luke Donnelly
 * Classes
 * Models a realworld object 
 * defines attributes of object called fields
 * defines capabilities of object called methods
 * unlike structs you can inheirit from a class and make a more specific subclass
 */

using System;


namespace CSharp5
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        //overloading a constructor
        public Animal(string name = "No Name")
        {
            // this.name refers to the objects name
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            // this.name refers to the objects name
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        // static fields change for every object
        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
