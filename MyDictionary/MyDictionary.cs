using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<T>
    {
        T[] arr;
        T[] tempArray;

        public MyDictionary()
        {
            arr = new T[0];
        }

        public void Add(T item)
        {
            tempArray = arr;
            arr = new T[arr.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                arr[i] = tempArray[i];
            }
            arr[arr.Length - 1] = item;

        }

        public int Count
        {
            get { return arr.Length; }
        }
    }
}
