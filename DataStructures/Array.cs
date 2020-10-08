using System;
using static System.Console;

namespace DataStructures
{
    public class Array
    {
        private int[] _items;
        private int _count;

        public Array(int length)
        {
            _items = new int[length];
        }

        public void Insert(int item)
        {
            if (_items.Length == _count)
            {
                int[] newItems = new int[_count * 2];

                for (int i = 0; i < _count; i++)
                {
                    newItems[i] = _items[i];
                }

                _items = newItems;
            }

            _items[_count++] = item;

        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
                if (_items[i] == item)
                    return i;

            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();

            for (int i = index;  i < _count; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
        }
        public void Print()
        {
            for (var i = 0; i < _count; i++)
            {
                WriteLine(_items[i]);
            }
        }
    }
}