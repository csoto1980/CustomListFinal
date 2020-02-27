using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_2020
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member Variables

        private T[] myArray; // Creatinog a private generic array | list has array capacity & count
        private int capacity; //how much is available | amount of seats in a bus
        public int Capacity //need set
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
        public void Add(T item) //add to list /array
        {
            //get item into array at correct spot | item needs to land at the next avaial index*****
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
            //increment count **CHECK**
            count++;
            //if capacity is more than for increase capacity by 4
            //check to make sure it persists
            //count == maxcapacity, we need to increases capacity and copy
            //increase the capacity start out of 4 make the size 8
            //try adding 5 and make sure cap is 8
            //arrange check to see make sure to put 5th in
            //make sure one of the original 4 are still there.
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (myArray[i].Equals(item))
                {
                    count--;
                    ShiftMyArray(i);
                    return true;
                }
            }
            return false;
            //deccrement count
            //item needs to land at next available index
            //check to make sure it persists
            //count == maxcapacity, we need to decreases capacity and copy
        }
        private void ShiftMyArray(int currentIndex)
        {
            for (int i = currentIndex; i < count; i++)
            {
                myArray[i] = myArray[i + 1];
            }
        }
        public override string ToString(T item)
        {
            //public override string ToString()
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //overload Plus Operator
        //public static MyList<T> operator + (MyList<T> list1, MyList<T> list2)
    }
}
