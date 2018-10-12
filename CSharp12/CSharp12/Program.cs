/* Luke Donnelly
 * C# Pt. 12
 * Covers Generic Collections, Generic Methods, Generic Structs, and Delegates
 * Generic Collections are type safe
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            animalList.Add(new Animal() { Name = "Doug" }); 
            animalList.Add(new Animal() { Name = "Paul" }); 
            animalList.Add(new Animal() { Name = "Sally"});

            animalList.Insert(1, new Animal() { Name = "Steve" });

            animalList.RemoveAt(1);

            Console.WriteLine("Num of Animals : {0}", animalList.Count);

            foreach(Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            int x = 5, y = 4;
            Animal.GetSum(ref x, ref y);

            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);

            Rectangle<int> rect1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rect1.GetArea());

            Rectangle<string> rect2 = new Rectangle<string>("10", "15");
            Console.WriteLine(rect2.GetArea());

            Arithmetic add, sub, addSub;

            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            sub = addSub - add;

            Console.WriteLine("Add 6 & 10");
            add(6, 10);

            Console.WriteLine("AddSub 6 & 10");
            addSub(6, 10);

            Console.ReadLine();
        }

        // Example of a generic struct, allows multiple datatypes. 
        // Allows overloading of parameters, while keeping the same functionality 
        public struct Rectangle<T>
        {
            public T width;
            public T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { width = length; }       
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);

                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        /* Delegates allow to reference methods inside a delegate object */
        /* Allow to neatly format a chain of calls */
        #region Delegate Code
        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        #endregion
    }
}
