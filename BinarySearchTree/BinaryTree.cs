using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T>
    {
        public Node<T> root;
        private bool rootSet;
        
        public BinaryTree()
        {
            root = new Node<T>();
            rootSet = false;
        }
        
        public void InsertValue(Node<T> node)
        {
            bool nodeInserted = false;
            if (!rootSet)
            {
                root.value = node.value;
                rootSet = true;
                nodeInserted = true;
            }
            Node<T> temporaryValue = root;
            while (!nodeInserted)
            {
                if (Comparer<T>.Default.Compare(node.value, temporaryValue.value) < 0)
                {
                    if (temporaryValue.leftValue == null)
                    {
                        temporaryValue.leftValue = node;
                        nodeInserted = true;
                    }
                    temporaryValue = temporaryValue.leftValue;
                }
                else if (Comparer<T>.Default.Compare(node.value, temporaryValue.value) >= 0)
                {
                    if (temporaryValue.rightValue == null)
                    {
                        temporaryValue.rightValue = node;
                        nodeInserted = true;
                    }
                    temporaryValue = temporaryValue.rightValue;
                }
            }
        }
        public Node<T> Search(T value)
        {
            if (root.value == null)
                Console.WriteLine("Tree is Empty");

            Node<T> temporaryValue = root;
            while (Comparer<T>.Default.Compare(value, temporaryValue.value) != 0)
            {
                if (temporaryValue.leftValue == null && temporaryValue.rightValue == null)
                {
                    Console.Clear();
                    Console.WriteLine("Value does not exist in tree");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (Comparer<T>.Default.Compare(value, temporaryValue.value) == 0)
                {
                    break;
                }
                else if (Comparer<T>.Default.Compare(value, temporaryValue.value) > 0)
                {
                    temporaryValue = temporaryValue.rightValue;
                    Console.WriteLine("Going right...");
                }
                else if (Comparer<T>.Default.Compare(value, temporaryValue.value) < 0)
                {
                    temporaryValue = temporaryValue.leftValue;
                    Console.WriteLine("Going left...");
                }
            }
            return temporaryValue;
        }
    }
}
