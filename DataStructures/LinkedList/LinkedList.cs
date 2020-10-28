using System;
using System.Collections.Generic;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        
        }
        private Node First { get; set; }
        private Node Last { get; set; }
        public int Size { get; private set; }

        public void AddLast(int item)
        {
            var node = new Node { Value = item };

            if (IsEmpty())
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }

            Size++;

        }

        public void AddFirst(int item)
        {
            var node = new Node { Value = item};
            if (IsEmpty())
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }
            Size++;
        }

        public int IndexOf(int item)
        {
            var index = 0;
            var current = First;
            while (current != null)
            {
                if (current.Value == item) return index;
                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(int item) => IndexOf(item) != -1;

        public void RemoveFirst()
        {
            if (IsEmpty()) 
                throw new InvalidOperationException("The List is empty");
            if (First == Last)
            {
                First = Last = null;
            }
            else
            {
                var second = First.Next;
                First.Next = null;
                First = second;
            }
            
            Size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty()) 
                throw new InvalidOperationException("The List is empty");
            if (First == Last)
            {
                First = Last = null;
            }
            else
            {
                var previous = GetPrevious(Last);
                Last = previous;
                previous.Next = null;
            }
            Size--;
        }

        private Node GetPrevious(Node node)
        {
            var current = First;
            while (current != null)
            {
                if (current.Next == node)
                    return current;
                current = current.Next;
            }

            return null;
        }

        public List<int> ToList()
        {
            var list = new List<int>();
            var current = First;
            while (current != null)
            {
                list.Add(current.Value);
                current = current.Next;
            }

            return list;
        }
        
        private bool IsEmpty() => First == null;
    }
    
}