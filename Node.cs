using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_console
{
    public class Node
    {
        public int value;
        public Node right;
        public Node left;
        public Node(int value)
        {
            this.value = value;
            this.right = this.left = null;            
        }
    }
}
