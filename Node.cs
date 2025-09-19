using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_console
{
    public class Node
    {
        public char data;
        public Node right;
        public Node left;
        public Node(char value)
        {
            this.data = value;
            this.right = this.left = null;            
        }
    }
}
