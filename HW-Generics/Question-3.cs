using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    class SortedLinkedList<TData> where TData : struct
    {

        TData[] arr = new TData[100];

        public int Count { get; set; } = 0;

        public void Add(TData td)
        {
            arr[Count] = td;
            Count++;
            Array.Sort(arr);
        }
    }
}