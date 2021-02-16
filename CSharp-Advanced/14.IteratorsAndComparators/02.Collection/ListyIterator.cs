using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {

        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            index = 0;
        }

        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
            index = 0;
        }

        public bool Move()
        {
            bool hasNext = HasNext();

            if (hasNext)
            {
                index++;
            }

            return hasNext;
        }

        public void Print()
        {
            if (index >= items.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(items[index]);
        }

        public bool HasNext()
        {
            return index < items.Count - 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
