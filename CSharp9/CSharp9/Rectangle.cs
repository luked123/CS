using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class Rectangle : Shape
    {
        public double Length { get; set; } = 0;
        public double Width { get; set; } = 0; 

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width; 
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Rectangle has {Length} length and {Width} width"); 
        }
    }
}
