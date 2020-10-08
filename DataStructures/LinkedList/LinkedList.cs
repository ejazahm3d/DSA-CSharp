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

        public void AddLast(int item)
        {
            var node = new Node() { Value = item, Next = null};
            
            if (First == null)
            {
                First = node;
                Last = node;
            } 
            else
            {
                Last.Next = node;
                Last = node;
            }

        }
    }
    
}