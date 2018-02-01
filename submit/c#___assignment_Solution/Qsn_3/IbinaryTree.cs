using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_tree
{
    interface IbinaryTree<T>
    {
        void Add(T val);

        node<T> getRoot(binaryTree<T> b);

    }
}
