/* Luke Donnelly
 * C# Pt 6
 * Covers Public, Private, Protected
 * Constants, Read-Only, Constructors, Setters, Getter, Properties & Static.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");

            Animal fox = new Animal("Oscar", "Rawrrr");

            // assigning through properties
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Luke";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter ID is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals : {0} at {1}", Animal.NumOfAnimals, Animal.SHELTER);



            Console.ReadLine();
        }
    }
}