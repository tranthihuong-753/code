using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLVGT
{
    // tao node 
    //class nodeTree
    //{
    //    int value;
    //    nodeTree left, right;
    //    nodeTree()
    //    {
    //        value = 0;
    //    }
    //    nodeTree(int x)
    //    {
    //        value = x;
    //    }
    //}
    internal class treeAlgothrm 
    {
        public class nodeTree
        {
            public int value;
            public nodeTree left, right;
            public nodeTree()
            {
                value = 0;
            }
            public nodeTree(int x)
            {
                this.value = x;
            }
        }
        public class myTree
        {
            public nodeTree root;
            // Phuong thuc hien thi node p trong cay . Input : node p 
            public void showOne(nodeTree p)
            {
                if (p == null)
                {
                    return;
                }
                else
                {
                    Console.Write("     " + p.value);
                }
            }
            // Phuong thuc hien thi cay theo Pre 
            public void showPre(nodeTree p)
            {
                if (p == null)
                {
                    return;
                }
                showOne(p);
                showPre(p.left);
                showPre(p.right);
            }
        }

        static void Main(string[] args)
        {
            // Tao cay 
            nodeTree t1 = new nodeTree(1);
            nodeTree t2 = new nodeTree(2);
            nodeTree t3 = new nodeTree(3);
            //nodeTree t4 = new nodeTree(4);
            //nodeTree t5 = new nodeTree(5);
            //nodeTree t6 = new nodeTree(6);
            //nodeTree t7 = new nodeTree(7);
            //nodeTree t8 = new nodeTree(8);
            //nodeTree t9 = new nodeTree(9);

            t1.left = t2;
            t1.right = t3;
            //t2.left = t4;
            //t2.right = t5;
            //t3.left = t6;
            //t3.right = t7;
            //t4.left = t8;
            //t4.right = t9;

            myTree tree = new myTree();
            tree.root = t1;
            tree.showPre(tree.root);

        }
    }
}

