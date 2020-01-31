using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node<T>
    {
        public Object Data;
        public Node<T> next;
        public Node<T> Left;
        public Node<T> Right;
        public Node(T Data)
        {

            this.Data = Data;
            this.next = null;
            this.Left = null;
            this.Right = null;

        }
    }
}
