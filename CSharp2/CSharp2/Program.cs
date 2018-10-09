/* Luke Donnelly
 * C# Pt 2
 * The basis of Arrays, For loops, String, Builder, Casting
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var intVal = 1234;  // Implicit Typing
            Console.WriteLine("intVal Type : {0}", intVal.GetType());

            // Arrays 
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNums 0 : {0}", favNums[0]);
            Console.WriteLine();

            // Types of arrays
            string[] customers = { "Bob", "Sally", "Sue" };      // String array 
            var employees = new[] { "Mike", "Paul", "Rick" };    // Implicit array
            object[] randomArray = { "Paul", 45, 1.234 };         // Object array for allowed multiple objects

            Console.WriteLine("randomArray 0 : {0}", randomArray[2].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            Console.WriteLine();

            // loops through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("randomArray[{0}] = {1}", i, randomArray[i]);
            }
            Console.WriteLine();

            // Multideminsional arrays
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };
            Console.WriteLine("MultiDemensional Value for 1,1 is {0}", custNames[1, 1]);

            // Looping through multideminsional arrays
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine("custName[{0},{1}] : {2}", i, j, custNames[i, j]);
                }
            }
            Console.WriteLine();

            // Demonstrating for each and array functions
            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");
            Array.Sort(randNums);
            PrintArray(randNums, "Sorted");
            Array.Reverse(randNums);
            PrintArray(randNums, "Reverse");
            Console.WriteLine("1 at Index: {0}", Array.IndexOf(randNums, 1));



            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, startInd, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }

            int[] numArray = { 1, 11, 22 };

            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

            int[] allVal = Array.FindAll(numArray, GT10);
            PrintArray(allVal, "All > 10");
            Console.WriteLine("Index for an element > 10 in numArray: {0}", Array.FindIndex(numArray, GT10));

            // Practice with string builders, an efficient way to handle text
            StringBuilder sb1 = new StringBuilder("Random Text");    // Defaults to 16 chars
            StringBuilder sb2 = new StringBuilder("More Stuff that is important", 256);

            Console.WriteLine("Capacity for sb1 : {0}", sb1.Capacity);
            Console.WriteLine("Capacity for sb2 : {0}", sb2.Capacity);
            Console.WriteLine("Length for sb1 : {0}", sb1.Length);
            Console.WriteLine("Length for sb2 : {0}", sb2.Length);

            sb2.AppendLine("\nMore important stuff");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            Console.WriteLine(sb2.ToString());

            sb2.Replace("text", "characters");
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb1.Equals(sb2));
            sb2.Insert(11, " that's great");

            Console.WriteLine(sb2.ToString());

            sb2.Remove(11, 7);

            Console.WriteLine(sb2.ToString());

            // Casting 
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} Cast : {1}", num1.GetType(), num2.GetType());

            Console.ReadLine();

        }


        // Prints the given array with a message
        static void PrintArray(int[] array, string mess)
        {
            Console.WriteLine("{0}", mess);
            Console.Write("[");
            foreach (int num in array)
            {
                if (Array.IndexOf(array, num) != array.Length - 1)
                {
                    Console.Write("{0}, ", num);
                }
                else
                {
                    Console.Write("{0}]\n", num);
                }
            }
        }

        // Predicate that takes in value and determines if value if 
        // greater than 10
        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}