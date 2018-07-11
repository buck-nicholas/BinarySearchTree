using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] numberArray = new int[200000];
            Random rand = new Random();
            BinaryTree<int> newTree = new BinaryTree<int>();
            Console.WriteLine("Generating Tree...");
            stopwatch.Start();
            for (int i = 0; i < 200000; i++)
            {
                Node<int> insertNode = new Node<int>();
                insertNode.value = rand.Next(5001);
                newTree.InsertValue(insertNode);
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed in creation {0} milliseconds", stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            // Searchable value
            Node<int> searchObject = newTree.Search(3231);
            stopwatch.Stop();
            Console.WriteLine("Value {0} found in {1} milliseconds", searchObject.value, stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
