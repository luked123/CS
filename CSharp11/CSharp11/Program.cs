/* Luke Donnelly
 * C# Pt. 11
 * Covers Collections: ArrayLists, Dictionaries, Queues and Stacks
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regions allow code to be, collapsable keeping code more organized. 
            #region ArrayList Code  
            // ArrayList are resizable arrays that can hold different data types
            // This section just goes over the various types of methods that can be used
            // in array lists

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}", aList.Count);

            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1, "Turkey");

            ArrayList range = aList2.GetRange(0, 2);

            foreach(object o in range)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            string[] myArray = (string[])aList2.ToArray(typeof(string));

            string[] customers = { "Bob", "Sally", "Sue" };

            ArrayList custArrayList = new ArrayList();

            custArrayList.AddRange(customers);

            foreach(string s in custArrayList)
            {
                Console.WriteLine(s);
            }

            #endregion

            #region Dictionary Code
            // Dictionaries store key value pairs
            // Code demonstrates various methods used in dictionaries

            // must state what data type will bassociated with key and value
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            superheroes.Remove("Barry West");

            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));
            superheroes.TryGetValue("Clark Kent", out string test);

            Console.WriteLine($"Clark Kent : {test}");

            foreach(KeyValuePair <string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            superheroes.Clear();

            #endregion

            #region QueueCode
            // Queues are a FIFO collection
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove head : {0}", queue.Dequeue());
            Console.WriteLine("Peek at head : {0}", queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ", numArray));

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            #endregion

            #region StackCode
            // Stacks are LIFO collection

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Peek at top of stack : {0}", stack.Peek());
            Console.WriteLine("Remove top of stack : {0}", stack.Pop());
            Console.WriteLine("Stack Contain 1 : {0}", stack.Contains(1));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(", ", numArray2));

            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }

            stack.Clear();

            #endregion

            Console.ReadLine();
        }
    }
}
