/* Luke Donnelly
 * C# Pt 5
 * This tutorial covers Structs, Classes, Fields, Methods, Constructors,
 * Static, Static Classes, Nullable Types
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 5);

            Console.WriteLine("rect1 length is {0} and its width is {1}", rect1.GetLength(), rect1.GetWidth());
            Console.WriteLine("rect1 area is {0}", rect1.Area());

            Rectangle rect2;
            rect2.length = 200;
            rect2.width = 50;
            Console.WriteLine("rect2 area is {0}", rect2.Area());
            Console.WriteLine("rect2 length is {0}", rect2.length);

            // Demonstrates classes
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaww"
            };

            // Using the constructor method
            Animal dog = new Animal("Bruiser", "Woof");

            Console.WriteLine("# of Animals: {0}", Animal.GetNumAnimals());
            fox.MakeSound();
            dog.MakeSound();

            // Demonstrates a static class, don't need to create an object to access its methods. Used for utility
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

            //Null values (must include the ?_
            int? randNum = null;

            // checks for null
            if (randNum == null)
            {
                Console.WriteLine("randNum is Null");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is Null");
            }

            Cars mustang = new Cars(color: "red", name: "Mustang", miles: 500000);

            mustang.MakeSound();

            Console.ReadLine();

        }

        // User defined type that allows multiple fields and methods
        struct Rectangle
        {
            public double length;
            public double width;

            // Contructor method initializes values default values are 1 and 1
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }

            public double GetLength()
            {
                return length;
            }

            public double GetWidth()
            {
                return width;
            }
        }
    }
}