using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    class CustomList<T>
    {
        private List<T> internalList;

        public CustomList()
        {
            internalList = new List<T>();
        }

        public CustomList(int capacity)
        {
            internalList = new List<T>(capacity);
        }

        public void Add(T item)
        {
            internalList.Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            internalList.AddRange(items);
        }

        public bool Contains(T item)
        {
            return internalList.Contains(item);
        }

        public void CopyTo(T[] array)
        {
            internalList.CopyTo(array);
        }

        public int IndexOf(T item)
        {
            return internalList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            internalList.Insert(index, item);
        }

        public void InsertRange(int index, IEnumerable<T> items)
        {
            internalList.InsertRange(index, items);
        }

        public bool Remove(T item)
        {
            return internalList.Remove(item);
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < internalList.Count)
            {
                internalList.RemoveAt(index);
                return true;
            }
            return false;
        }

        public T[] ToArray()
        {
            return internalList.ToArray();
        }
    }
}
