/* Luke Donnelly
 * C# Pt. 3
 * Covers If, Else, Else If, Ternary Operator, Switch Goto, While, Do While,
 * Exception Handling. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Relational Operations : > < >= <= == !=
            // Logical Operator : && || ! 

            int age = 17;

            // If, Else If, Else
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to Elementary School");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to Middle School");
            }
            else if ((age >= 13) && (age <= 18))
            {
                Console.WriteLine("Go to High School");
            }
            else
            {
                Console.WriteLine("Go to College");
            }

            if ((age < 14) || (age < 19))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = {0}", !true);

            // Ternary operator
            // used for assignment (assigned) = (test case) ? assignment true  or assignment false    
            bool canDrive = age >= 16 ? true : false;

            // switch statement can't do ranges in C#
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;    // gos to where this statement is formed
            }

            OtherSchool:
            Console.WriteLine("Elentary, Middle, High School");

            string name = "Derek";
            string name2 = "Derek";

            if (name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            // While loop
            int start = 1; // must define the iterator outside the while loop
            while (start <= 10)
            {
                if (start % 2 == 0)
                {
                    start++;
                    continue;        //continues with at the start of the while loop
                }
                if (start == 9)
                {
                    break;           // breaks out of the loop
                }
                Console.WriteLine(start);
                start++;
            }

            // Do while loop for executing inside the vlock at least once
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed correctly!");


            // Really brief explanation of exception handling if an exception occurs
            // (in this case dividing by zero) it will catch the exception and execute some code. 
            int num1 = 0;
            int num2 = 1;

            double[] array = { 1, 2, 4, 0, 5, 6 };

            while (num2 != array.Length)
            {
                try
                {
                    Console.WriteLine("{0} / {1} = {2}", array[num1], array[num2], DoDivision(array[num1], array[num2]));
                }
                catch (DivideByZeroException ex)     // catches a specific exception
                {
                    Console.WriteLine("You can't divide by zero!");

                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Cleaning Up"); // anycode you want to do to clean up exception handling
                }
                num1++;
                num2++;
            }

            Console.ReadLine();
        }

        // shows example of using exceptions 
        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}