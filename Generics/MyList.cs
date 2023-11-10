﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // <> içerisi çalışılacak tipi belirtir. T yerine farklı şey de yazılabilir.
    internal class MyList<T>
    {
        // Dizi oluşturuldu
        T[] items;

        // Oluşturulan dizi constructor içerisinde new'lendi
        // constructor
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
