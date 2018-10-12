/* Luke Donnelly
 * C# Pt 9 
 * Covers Abstract Classes, Abstract Methods, Base Classes, Is
 * As, Casting and Polymorphism
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract classes allow for collections of same object
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;  // Tests if object is of a specific type as

                if(testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if(s is Circle)       // another way to test if object is something
                {
                    Console.WriteLine("This isn't a Rectangle"); 
                }
                Console.WriteLine();
            }

            object circ1 = new Circle(4);       
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());

            Console.ReadLine();
        }
    }
}
