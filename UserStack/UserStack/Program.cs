using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStack
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("racecar");
            Console.ReadLine();
        }

        public static void IsPalindrome(string word)
        {
            GeneralStack stack1 = new GeneralStack();
            
            foreach(char c in word)
            {
                Console.WriteLine(c);
                Node newNode = new Node(c);
                stack1.Push(newNode);
            }

            while(stack1.Peek() != null)
            {
                foreach(char c in word)
                {
                    Node top = stack1.Pop();
                    if ((char)top.Data != c)
                    {
                        Console.WriteLine("Word is not a palindrome");
                        return; 
                    }
                }
            }

            Console.WriteLine("Word is a palindrome");            
        }
    }
}
