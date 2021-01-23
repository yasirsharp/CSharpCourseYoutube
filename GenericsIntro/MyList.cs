using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class MyList<T> //Ben MyList te T ile çalışacağım.
    {
        T[] items;

        //Constructor("ctor + 2x/tab")
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}