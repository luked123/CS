using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Abstract classes are a class that you 
 * don't want to instantiate
 */

namespace CSharp9
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}"); 
        }

        // Abstract method to be overwritten
        public abstract double Area();

    }
}
