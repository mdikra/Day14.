using System.Collections.Generic;

namespace LinkedList
{
    internal class LinkedListNode
    {
        internal static LinkedListNode<object> next;
        private int data;

        public LinkedListNode(int data)
        {
            this.data = data;
        }

        public static int Data { get; internal set; }
    }
}