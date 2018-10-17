﻿/* Example of a custom collection Animal Farm */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp14
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm()
        {

        }

        // Example of an Indexor must use keyword this
        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count
        {
            get { return animalList.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
