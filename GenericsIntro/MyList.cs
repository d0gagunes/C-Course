using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
         T[] items;
        public MyList() //ctor yazip tab tab ile bunu olustururuz (constructor olustururuz)
        {
            items = new T[0];
        }
        public void Add (T item)
        {
            T[] tempArray = items; //Gecici dizinin referansi itemsin referansi
            items = new T[items.Length+1]; //Dizinin eleman sayisini bir arttiriyoruz.
            for (int i = 0; i <tempArray.Length; i++) //for tab tab
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
