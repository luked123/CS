/* Luke Donnelly
 * C# Pt. 16
 * Covers Threads, Sleep, Lock, 
 * Priority, Passing Data to Threads
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Threads allow code to be ran congruently, they can share data and resources
 * You cannot tell when a thread will be executing
 */

namespace CSharp16
{
    class Program
    {
        static void Main(string[] args)
        {

            // Example of threads running
            /*
            Thread t = new Thread(Print1);

            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            */

            // int num = 1; 

            // Sleep allows us to slow down a thread
            /*
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread Ends");
            */

            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for(int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t; 
            }

            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
            }

            Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            // Example of passing parameters to a thread
            Thread t2 = new Thread(() => CountTo(10));
            t2.Start();

            // Example of creating multiple threads simultaneously
            new Thread(() => { CountTo(5); CountTo(6); }).Start();


            Console.ReadLine();
        }

        static void Print1()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        class BankAcct
        {
            private Object acctLock = new object();
            double Balance { set; get; }

            public BankAcct(double bal)
            {
                Balance = bal;
            }

            public double Withdraw(double amt)
            {
                if((Balance - amt) < 0)
                {
                    Console.WriteLine($"Sorry ${Balance} in account");
                    return Balance;
                }

                lock (acctLock) // Locks are used to protect data from corruption (race conditions)
                {
                    if(Balance >= amt)
                    {
                        Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
                        Balance -= amt;
                    }
                    return Balance;
                }
            }

            public void IssueWithdraw()
            {
                Withdraw(1);
            }

        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i < maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
