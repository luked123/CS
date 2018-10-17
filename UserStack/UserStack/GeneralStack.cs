using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStack
{
    class GeneralStack
    {
        private Node top;

        public GeneralStack( Node top = null)
        {
            this.top = top; 
        }

        public void Push(Node element)
        {
            if (top == null)
            {
                top = element;
            }
            else
            {
                top.Next = element;
                element.Prev = top;
                top = element;
            }
        }

        public Node Pop()
        {
            if(top != null)
            {
                Node tmp = top;
                top = top.Prev;
                if(top != null) { top.Next = null; }
                return tmp;
            }
            return null; 
        }

        public void PopAll()
        {
            while(top != null)
            {
                Pop();
            }
        }

        public Node Peek()
        {
            return top;
        }
    }
}
