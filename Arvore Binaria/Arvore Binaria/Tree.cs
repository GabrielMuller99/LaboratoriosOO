﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore_Binaria
{
    class Tree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
           
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }

            return true;
        }

        /*public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }*/

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else
            {
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                {
                    return parent;
                }
                if (value < parent.Data)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }

            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void PrintPreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                PrintPreOrder(parent.LeftNode);
                PrintPreOrder(parent.RightNode);
            }
        }

        public int NodeCount(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            
            return 1 + NodeCount(root.LeftNode) + NodeCount(root.RightNode);
        }

        public void PrintInOrder(Node parent)
        {
            if (parent != null)
            {
                PrintInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                PrintInOrder(parent.RightNode);
            }
        }

        public void PrintPostOrder(Node parent)
        {
            if (parent != null)
            {
                PrintPostOrder(parent.LeftNode);
                PrintPostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}

