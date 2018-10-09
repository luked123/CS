using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5
{
    class Cars
    {
        private string name;
        private string color;
        private int miles;
        private static int numOfCars = 0;

        public Cars()
        {
            name = "No Name";
            color = "No Color";
            miles = 0;
        }

        public Cars(string name, string color, int miles)
        {
            this.name = name;
            this.color = color;
            this.miles = miles;
            numOfCars++;
        }

        public void MakeSound()
        {
            Console.WriteLine("Beep Beep");
        }

    }
}