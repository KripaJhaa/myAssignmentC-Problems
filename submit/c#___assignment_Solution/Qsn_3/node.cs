using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_tree
{
   public class node<T>
    {
        public node<T> left, right;
        public T val;

        public node(T val1)
        {
            this.val = val1;
            this.left = null;
            this.right = null;
        }
    }
}
