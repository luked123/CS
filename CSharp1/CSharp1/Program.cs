/* Luke Donnelly 
 * C# pt 1
 * The basis of simple commands, datatypes, and objects
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


// Globallly Unique Objects 
namespace CSharp1
{
    class Program
    {

        // All execution begins here
        static void Main(string[] args)
        {
            // Basic write to output
            Console.WriteLine("Hello World");

            // Basic for loop that reads command line arguments
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            // Another way to get command line arguments
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));

            // Calls say hello function
            SayHello();

            /* Datatypes */

            // Booleans (true or false values)
            bool canIVote = true;

            // Integer (32 bit signed value)
            int isInt = 5;
            Console.WriteLine("The largest value an integer can take is {0}", int.MaxValue);
            Console.WriteLine("The smallest value an integer can take is {0}", int.MinValue);
            Console.WriteLine();

            // Longs (64 bit signed value)
            long isLong = 3892173981273897;
            Console.WriteLine("The largest value a Long can take is {0}", long.MaxValue);
            Console.WriteLine("The smallest value a Long can take is {0}", long.MinValue);
            Console.WriteLine();

            // Decimals (128 bit signed value) accurate to 28 digits
            Console.WriteLine("The largest value for a decimal is {0}", decimal.MaxValue);
            Console.WriteLine("The smallest value for a decimal is {0}", decimal.MinValue);
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            Console.WriteLine();

            // Doubles (64 bit floating type) not as accurate as decimals
            Console.WriteLine("The largest value for a double is {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("The smallest value for a double is {0}", double.MinValue.ToString("#"));
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.000000000000002;
            Console.WriteLine("DEC : PI + bigNum = {0}", dblPiVal + dblBigNum);
            Console.WriteLine();

            // Floats (32 bit floating type) not as accurate as a double
            float isFloat = 5.89F;
            Console.WriteLine("The largest value a float can have is {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("The smallest value a float can have is {0}", float.MinValue.ToString("#"));
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.0000002F;
            Console.WriteLine("DEC : PI + bigNum = {0}", fltPiVal + fltBigNum);
            Console.WriteLine();

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int -128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535


            // Convert from string to other data types
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            /* Dates and Times */

            // Creates a datetime object
            DateTime awesomeDate = new DateTime(1990, 4, 21);

            // Finds the day of the week the date occured
            Console.WriteLine("Day of the Week : {0}", awesomeDate.DayOfWeek);

            // Increments date
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(3);
            awesomeDate = awesomeDate.AddYears(5);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            // Creates a TimeSpan object
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Adds and Subtracts Time
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));

            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            /* Huge numbers */
            BigInteger bigNum = BigInteger.Parse("1234512345123451234512345");
            Console.WriteLine("BigNum * 2 = {0}", bigNum * 2);
            Console.WriteLine();

            /* Formatting strings */
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);   // 4 values worth
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas : {0:n4}", 2300);  // up to 4 decimal places with commas
            Console.WriteLine();

            /* Strings */
            string randString = "This is a string";

            // Bunch of different string functions
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0}", randString.Remove(0, 6));
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));
            Console.WriteLine("Repalce String : {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Compare A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randString.Trim());
            Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("Lowercase : {0}", randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

            // Verbatim string 
            Console.Write(@"Exactly What I Typed ' \");



            // Allows script to keep running till enter is pressed
            Console.ReadLine();

        }

        // A simple function that gets the users name
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
