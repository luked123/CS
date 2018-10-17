using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStack
{
    class Node
    {
        public object Data { get; set; }
        public Node Prev { get; set; } = null;
        public Node Next { get; set; } = null;

        public Node(object data = null)
        {
            Data = data; 
        }

    }
}
