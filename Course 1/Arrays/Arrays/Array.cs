using System;
using System.Linq;

namespace Arrays
{

    // Runtime Complexity of this Class: O(n)
    
    public class Array
    {
        private int[] items;
        private int count;
        public Array(int size)
        {
            items = new int[size];

        }

        public void Print()
        {
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Insert(int value)
        {
            if (items.Length == count)
            {
                var newArray = new int[count * 2];
                for (var i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            }

            items[count++] = value;
        }

        public void InsertAt(int value, int index)
        {
            if (items.Length == count)
            {
                var newArray = new int[count * 2];
                for (var i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            }

            for (int i = index; i < count; i++)
            {
                items[i + 1] = items[i];
                items[i] = value;
                
            }
            
            count++;
            
        }


        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentException();

            for (int i = index; i < count; i++)
                items[i] = items[i + 1];
            
            count--;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public int LargestNumber()
        {
            return items.Max();
        }
    }
}