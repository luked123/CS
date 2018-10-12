/* First class to use interfaces */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    // Here we inherit from the interface and must implement it's properties and methods.
    class Vehichle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehichle(string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed; 
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} moves forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} moves forward at Stops");
            Speed = 0;
        }
    }
}
