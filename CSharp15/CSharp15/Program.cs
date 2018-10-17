/* Luke Donnelly
 * CSharp Pt.15
 * Covers LINQ, From, Whrere, Orderby, Select, IEnumarable, Inner Joins
 * Group Joins
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp15
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();

            QueryIntArray();

            QueryArrayList();

            QueryCollection();

            QueryAnimalData();

            Console.ReadLine();
        }


        /* LINQ stands for language intergrated query, provides a way to work with data and can work
         * with other types of data besides just databases (SQL)
         */
        static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin",
                "Benji", "Charlie B. Barkin", "Lassie", "Snoopy"};

            var dogSpaces = from dog in dogs         // comes from dogs array and stored temp in dog variable
                            where dog.Contains(" ")  // where is used to match conditions where it succeeds
                            orderby dog descending   // orders the data
                            select dog;              // defines the var that is going to bechecked by this condition

            foreach(var i in dogSpaces)
            {
                Console.WriteLine(i);                    
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine($"Get Type : {gt20.GetType()}");

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            // The query automatically updates, no need to requery
            nums[0] = 40; 
            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            return arrayGT20;
        }

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
           {
               new Animal
               {
                   Name = "Heidi",
                   Height = .8,
                   Weight = 18
               },

               new Animal
               {
                   Name = "Shrek",
                   Height = 4,
                   Weight = 130
               },

               new Animal
               {
                   Name = "Congo",
                   Height = 3.8,
                   Weight = 90
               },
           };

            // Must convert arraylist to enumerable before query
            var famAnimalEnum = famAnimals.OfType<Animal>();
            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach(var animal in smAnimals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();
        }

        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal("German Shepard", 77, 25),
                new Animal("Chihuahua", 4.4, 7),
                new Animal("Saint Bernard", 200, 30)
            };

            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog; 

            foreach(var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}", dog.Name, dog.Weight);
            }

            Console.WriteLine();
        }

        static void QueryAnimalData()
        {
            Animal[] animals = new Animal[]
            {
                new Animal{Name = "German Shepard", Weight = 77, Height = 25, AnimalID = 1},
                new Animal{Name = "Chihuahua", Weight = 4.4, Height = 7, AnimalID = 2},
                new Animal{Name = "Saint Bernard", Weight = 200, Height = 30, AnimalID = 3},
                new Animal{Name = "Pug", Weight = 16, Height = 12, AnimalID = 1},
                new Animal{Name = "Beagle", Weight = 23, Height = 15, AnimalID = 2}
            };

            Owner[] owners = new Owner[]
            {
                new Owner{Name = "Doug Parks", OwnerID = 1},
                new Owner{Name = "Sally Smith", OwnerID = 2},
                new Owner{Name = "Paul Brooks", OwnerID = 3}
            };

            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };

            Array arrNameHeight = nameHeight.ToArray();

            foreach(var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();

            // example of inner join
            var innerJoin = from animal in animals
                            join owner in owners on animal.AnimalID
                            equals owner.OwnerID
                            select new { OwnerName = owner.Name, AnimalName = animal.Name };

            foreach(var i in innerJoin)
            {
                Console.WriteLine($"{i.OwnerName} owns {i.AnimalName}");
            }
            Console.WriteLine();

            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals
                            on owner.OwnerID
                            equals animal.AnimalID
                            into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2
                                          in ownerGroup
                                          orderby owner2.Name
                                          select owner2
                            };

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    Console.WriteLine("* {0}", animal.Name);
                }
            }
        }


    }
}
