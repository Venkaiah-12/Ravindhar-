using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node1
    {
        public Object Data;
        public Node1 next;
        public Node1 prev;
        public Node1 Left;
        public Node1 Right;
        public Node1(int Data)
        {
            this.Data = Data;
            this.next = null;
            this.Left = null;
            this.Right = null;
            this.prev = null;

        }
    }
}
