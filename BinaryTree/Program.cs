using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Node node = null;
            int[] array = new int[] { 6, 5, 11, 3, 7, 8,9,13,1,14,17,4 };
            for (int i = 0; i < array.Length; i++)
            {
                node = tree.Add(node, array[i]);
            }
            Console.WriteLine(node.Value);
            tree.Search(node,4);
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            this.Value = value;
        }

    }

    public class Tree
    {


        public Node Add(Node root, int number)
        {
            if (root is null)
            {
               // Console.WriteLine("Create root");
                root = new Node(number);
            }
            else if(root.Value>number)
            {
               // Console.WriteLine("Turn Left");
                root.Left = Add(root.Left,number);
                // return Add(root.Left,number);
            }
            else
            {
                //Console.WriteLine("Turn Right");
                root.Right = Add(root.Right, number);
            }
            return root;
        }

        public void Search(Node root,int number)
        {
            if (root.Value == number)
            {
                Console.WriteLine("We've found a number!");
            }
            else if(root.Value>number)
            {
                Console.WriteLine("Turn Left");
                Search(root.Left, number);
            }
            else if (root.Value < number)
            {
                Console.WriteLine("Turn Right");
                Search(root.Right, number);
            }
            else
            {
                Console.WriteLine("There is no number here...");
            }
        }
    }
}
