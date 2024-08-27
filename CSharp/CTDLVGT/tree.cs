using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
    internal class tree
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
                if(p == null)
                {
                    return;
                }
                showOne(p);
                showPre(p.left);
                showPre(p.right);
            }
            //1. Trả về true nếu cây rỗng, ngược lại trả về false.
            public Boolean isEmpty()
            {
                if(root == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //2.  Xóa một cây{.} 
            public void clear(nodeTree p)
            {
                root = null;
            }
            // 9. Đếm và trả về số lượng nút trong cây.
            int countTree = 0;
            public int count(nodeTree p)
            {
                if(p == null)
                {
                    return 0;
                }
                else
                {
                    countTree += 1;
                    count(p.left);
                    count(p.right);
                }
                return countTree;
            }
            ////11. Tìm và trả về nút có giá trị nhỏ nhất trong cây.
            public int min_helper(nodeTree p)
            {
                //if (p == null)
                //{
                //    Console.WriteLine("!!!@@@");
                //    return 0;
                //}
                int leftMin = min_helper(p.left);
                int rightMin = min_helper(p.right);
                return Math.Min(p.value, Math.Min(leftMin, rightMin));
            }
            public int min()
            {
                if (root == null)
                {
                    throw new Exception("Rong");
                }
                return min_helper(root);
            }
     
            //12. Tìm và trả về nút có giá trị lớn nhất trong cây.
            public nodeTree max(nodeTree p)
            {
                if(p == null)
                {
                    return null;
                }
                nodeTree max1 = max(p.left);
                nodeTree max2 = max(p.right);
                nodeTree maxx = p;
                if (max1.value > maxx.value)
                {
                    maxx = max1;
                }
                if (max2.value > maxx.value)
                {
                    maxx = max2;
                }
                return maxx;
            }
            //13. Trả về tổng của tất cả các giá trị trong cây.
            int summ;
            public int sum(nodeTree p)
            {
                if(p == null)
                {
                    return 0;
                }
                else
                {
                    summ += p.value;
                    sum(p.left);
                    sum(p.right);
                }
                return summ;
            }
            //14. Trả về giá trị trung bình của tất cả các giá trị trong cây con co node cha la p

            public float avg(nodeTree p)
            {
                float x = (float)sum(p);
                float y = (float)count(p);
                return x/y;
            }

        }

        static void Main(string[] args)
        {
            // Tao cay 
            nodeTree t1 = new nodeTree(1); 
            nodeTree t2 = new nodeTree(2);
            nodeTree t3 = new nodeTree(3);
            nodeTree t4 = new nodeTree(4);
            nodeTree t5 = new nodeTree(5);
            nodeTree t6 = new nodeTree(6);
            nodeTree t7 = new nodeTree(7);
            nodeTree t8 = new nodeTree(8);
            nodeTree t9 = new nodeTree(9);

            t1.left = t2;
            t1.right = t3;
            t2.left = t4;
            t2.right = t5;
            t3.left = t6;
            t3.right = t7;
            t4.left = t8;
            t4.right = t9;

            myTree tree = new myTree();
            tree.root = t1;
            Console.WriteLine("Ban dau");
            tree.showPre(tree.root);
            Console.WriteLine();
            Console.WriteLine("root truoc " + tree.root);
            Console.WriteLine("t1 truoc " + t1);

            Console.WriteLine("Sau");
            tree.clear(tree.root);
            tree.showPre(t2);
            Console.WriteLine("root sau "+tree.root);
            Console.WriteLine("t1 sau "+t1);
            //Console.WriteLine("max = "+tree.max(tree.root).value);
        }
    }
}
