/* Luke Donnelly
 * C# Pt 4
 * Focuses on Methods, Pass by Value, Pass by Reference, Out,
 * Params, Named Parameters, Method OverLoading, Enum. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x {0} ", x);
            Console.WriteLine("y {0} ", y);

            int solution;

            // Assigning a variable inside a method
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            // Passing by reference
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before Swap num1 = {0} : num2 = {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After Swap num1 = {0} : num2 = {1}", num1, num2);

            // Parameters
            // Variable amount of parameters
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 2, 3));

            // Named parmeters (parameter name): value
            PrintInfo(zipCode: 97503, name: "Luke");

            //Method overloading
            Console.WriteLine("5.0 + 4.5 = {0}", GetSum(5.0, 4.5));
            Console.WriteLine("5.0 + 4.5 = {0}", GetSum(5, 4));
            Console.WriteLine("5.0 + 4.5 = {0}", GetSum("5", "4"));

            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

            CarColor car2 = CarColor.Green;
            PaintCar(car2);

            Console.ReadLine();
        }


        // Demonstrates pass by value and method overloading
        static double GetSum(double x = 1, double y = 1) //Can pass a value to params if nothing is inputed
        {
            // trys to switch values through a method everything by default is pass by value
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }
        // Use the same function name but change parameters
        static double GetSum(string x = "1", string y = "1") //Can pass a value to params if nothing is inputed
        {
            double dblx = Convert.ToDouble(x);
            double dbly = Convert.ToDouble(y);
            return dblx + dbly;
        }

        // A way to work with variables outside a method and assign a varriable outside a method
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // Demostrates pass by reference (must include ref in parameters)
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        // demonstrating a variable number of values
        static double GetSumMore(params int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // Named parameters
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        //Enums is a custom datatype that allows symbolic names to represent data
        enum CarColor : byte      // defines the type of data in the enum
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with code {1}", cc, (int)cc);
        }
    }
}