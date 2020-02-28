using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_2020
{
    public class CustomList<T> : IEnumerable //IEmuberable - makes it possible to enumerate(mention a # of things one by one)
    {
        //Member Variables
        private T[] myArray; // Creatinog a private generic array | list has array capacity & count
        private int capacity; //how much is available | amount of seats in a bus
        public int Capacity //Capacity property
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private int count; // How much is inside | amount of people in a bus
        public int Count
        {
            get { return count; }
        }
        //indexer
        public T this[int number]//[] is the parameter | myList[2] //defines indexer to allow code to use [] notation
        {
            get { return myArray[number]; }
            set { myArray[number] = value; }
        }
        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            myArray = new T[capacity];
        }
        //Member Methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                T[] tempArray = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = myArray[i];
                }
                myArray = tempArray;
                myArray[count] = item;
            }
            else
            {
                myArray[count] = item;
            }
            count++;
            //if capacity is more than for increase capacity by 4
            //check to make sure it persists
            //count == maxcapacity, we need to increases capacity and copy
            //increase the capacity start out of 4 make the size 8
            //try adding 5 and make sure cap is 8
            //arrange check to see make sure to put 5th in
            //make sure one of the original 4 are still there.
            //get item into array at correct spot | item needs to land at the next avaial index*****
        }
        public bool Remove(T item)
        {
            bool found = false;
            T[] tempArray = new T[capacity];
            int j = 0; 
            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(item))
                {
                    found = true;
                }
                else
                {
                    tempArray[j] = myArray[i];
                    j++;
                } 
            }
            if (found)
            {
                count--;
            }
            myArray = tempArray;
            return found;
        }

        //public override string ToString(T item)
        //{
        //    //public override string ToString()
        //}
        
        // Custom clas to be iterable
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
        //overload Plus Operator

    }
}
