using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        public T value;
        public Node<T> rightValue;
        public Node<T> leftValue;

        public Node()
        {
            rightValue = null;
            leftValue = null;
        }
    }
}
