using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2HomeWork
{
    class Program
    {
        public class Tree
        {
            public class Node
            {
                public Node Right;
                public Node Left;
                public int Value;

                public Node(int value)
                {
                    Right = null;
                    Left = null;
                    Value = value;
                }
            }

            public Node Root;
            public int Count = 0;

            public Tree()
            {
                Root = null;
            }

            public Tree(int value)
            {
                Root = new Node(value);
            }

            public void AddNode()
            {
                _add(ref Root, Root.Value);
            }

            private void _add(ref Node node, int value)
            {
                if (value <= 20)
                {
                    node = new Node(value);
                    if (node.Value * 2 < 21)
                    {
                        _add(ref node.Right, node.Value * 2);
                    }
                    if (node.Value + 1 < 21)
                    {
                        _add(ref node.Left, node.Value + 1);
                    }
                    if (node.Value == 20)
                    {
                        Count++;
                    }
                }
            }

            #region Mass
            public void AddNodeMass(ref Node node, int value)
            {
                int i = 0;
                while (true)
                {
                    if (value <= 20)
                    {
                        if (value + 1 < 21)
                        {
                            _addMass(ref node, ref node.Right, node.Value);
                        }
                        if (value * 2 < 21)
                        {
                            _addMass(ref node, ref node.Left, node.Value);
                        }

                    }
                }
            }

            private void _addMass(ref Node prevNode, ref Node node, int value)
            {
                if (node == null)
                {
                    node = new Node(value);
                    node.Prev = prevNode;
                }
            }

            #endregion

            public int DisplayCount()
            {
                return Count;
            }
        }

        static bool Recur(int startIndex)
        {
            if (startIndex + 1 != 20)
            {
                if (startIndex * 2 == 20)
                {
                    return true;
                }
                return true;
            }

            return false;
        }

        static void Mass()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Рекурсия");
            Tree tree = new Tree(3);
            tree.AddNode();
            Console.WriteLine($"Количество путей получения из числа 3 числа 20: {tree.DisplayCount()}");
            Console.ReadKey();


        }
    }
}
