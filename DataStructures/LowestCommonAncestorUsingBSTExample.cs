using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class LowestCommonAncestorUsingBSTExample
    {
        public static void Execute()
        {
            BSTree<int> tree = new BSTree<int>();
            tree.Insert(new BSTNode<int>(20));
            tree.Insert(new BSTNode<int>(8));
            tree.Insert(new BSTNode<int>(22));
            tree.Insert(new BSTNode<int>(4));
            tree.Insert(new BSTNode<int>(12));
            tree.Insert(new BSTNode<int>(10));
            tree.Insert(new BSTNode<int>(14));

            tree.PreOrderTraverse(tree.root);

            Console.WriteLine("The lowest common ancestor of 4 and 14 in the preordered tree above is:");
            Console.WriteLine(FindTheLowestCommonAncestor<int>(tree.root, 4, 14).Data);
        }

        private static BSTNode<T> FindTheLowestCommonAncestor<T>(BSTNode<T> root, T value1, T value2) where T : IComparable<T>
        {
            BSTNode<T> cursor = root;

            while (cursor != null)
            {
                T value = cursor.Data;
                
                if (value.CompareTo(value1) > 0 && value.CompareTo(value2) > 0)
                {
                    cursor = cursor.left;
                }
                else if (value.CompareTo(value1) < 0 && value.CompareTo(value2) < 0)
                {
                    cursor = cursor.right;
                }
                else
                {
                    return cursor;
                }
            }

            return cursor; // only if empty tree.
        }
    }

