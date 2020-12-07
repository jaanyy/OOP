using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L9_8.CustomListSorter
{
    class CustomList<T>
        where T : IComparable<T>
    {
        public List<T> Data;

        public CustomList()
        {
            Data = new List<T>();
        }

        public void Add(T element)
        {
            Data.Add(element);
        }

        public T Remove(int index)
        {
            T element = Data[index];
            Data.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            return Data.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T temp = Data[index1];
            Data[index1] = Data[index2];
            Data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return Data.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return Data.Max();
        }

        public T Min()
        {
            return Data.Min();
        }
    }
}
