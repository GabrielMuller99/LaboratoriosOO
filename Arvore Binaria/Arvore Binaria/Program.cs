using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(59);
            list.Add(103);
            list.Add(48);
            list.Add(33);
            list.Add(51);
            list.Add(38);
            list.Add(79);
            list.Add(1);
            list.Add(235);
            list.Add(121);
            list.Add(223);
            list.Add(161);

            InsertListInTree(list);
            Console.ReadKey();
        }

        public static void InsertListInTree(List<int> list)
        {
            Tree binaryTree = new Tree();

            for (int i = 0; i < list.Count; i++)
            {
                binaryTree.Add(list[i]);
            }

            InOrder(binaryTree);
            int qtd = binaryTree.GetTreeDepth();
            Console.WriteLine(qtd);
            int nodes = binaryTree.NodeCount(binaryTree.Root);
            Console.WriteLine(qtd);
        }

        public static void InOrder(Tree binaryTree)
        {
            binaryTree.PrintInOrder(binaryTree.Root);
        }

    }
}
