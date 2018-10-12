/* Luke Donnelly
 * C# Pt 13
 * Covers Manipulating Lists : Lambda, Where, ToList, Select, Zip
 * Aggregate, Average, All, Any, Distinct, Except, Intersect
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    class Program
    {
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            // lambda expression define input parameters on the left and perform an opration on the right
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($" 5 * 2 = {dblIt(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            var evenList = numList.Where(a => a % 2 == 0).ToList();

            foreach (var e in evenList)
            {
                Console.WriteLine($"Even List: {e}");
            }

            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
            foreach (var e in rangeList)
            {
                Console.WriteLine($"Range List: {e}");
            }

            List<int> flipList = new List<int>();

            int i = 0;
            Random rnd = new Random();
            while(i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count);
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count);

            var nameList = new List<string> { "Doug" , "Bob", "Sally", "Sue", "Luke", "Derrek", "Josh", "Sam", "Travis" };
            Console.WriteLine("Number of names that start with S : {0}", nameList.Where(a => a.StartsWith("S")).ToList().Count);

            // select allows us to run a function on each item in a list
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(x => x * x);

            foreach(var square in squares)
            {
                Console.WriteLine(square);
            }

            // zip applies a function to two lists

            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var sum in sumList)
            {
                Console.WriteLine(sum);
            }

            // aggregate performs operation on each item in a list and carrys it forward
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum: {0}", numList2.Aggregate((x, y) => x + y));

            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Avg : {0}", numList3.AsQueryable().Average());

            // Asks a check if all values in list are greater than 3
            Console.WriteLine("All > 3 : {0}", numList3.All(x => x > 3));

            // Asks a check if any value is greater than 3
            Console.WriteLine("Any > 3 : {0}", numList3.Any(x => x > 3));

            // Distinct returns a list with only distinct values
            var numList4 = new List<int>() { 1, 2, 3, 2, 3 };
            Console.WriteLine("Distinct : {0}", string.Join(", ", numList4.Distinct()));

            // Except takes two lists and returns a list where values in the 2nd list are not found in the 1st list. 
            var numList5 = new List<int>() { 3 };
            Console.WriteLine("Except: {0}", string.Join(", ", numList4.Except(numList5)));

            // Intersect returns only a list where the values are found in both lists. 
            Console.WriteLine("Intersect: {0}", string.Join(", ", numList4.Intersect(numList5)));



            Console.ReadLine();

        }
    }
}
