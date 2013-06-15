using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NonRecursiveBSTTraversal
{
    public static void Execute()
    {
        BSTree<int> tree = new BSTree<int>();

        tree.Insert(new BSTNode<int>(5));
        tree.Insert(new BSTNode<int>(10));
        tree.Insert(new BSTNode<int>(8));
        tree.Insert(new BSTNode<int>(20));
        tree.Insert(new BSTNode<int>(2));
        tree.Insert(new BSTNode<int>(100));
        tree.Insert(new BSTNode<int>(1));
        tree.Insert(new BSTNode<int>(3));
        tree.Insert(new BSTNode<int>(80));
        tree.Insert(new BSTNode<int>(7));
        tree.Insert(new BSTNode<int>(19));
        tree.Insert(new BSTNode<int>(9));
        tree.Insert(new BSTNode<int>(110));

        CustomStack<BSTNode<int>> stack = new CustomStack<BSTNode<int>>();

        stack.Push(new linkedNode<BSTNode<int>>(tree.root));

        while (stack.head != null)
        {
            BSTNode<int> cursor = stack.Pop().Data;
            if (cursor == null)
                break;
            Console.WriteLine(cursor.Data);
            BSTNode<int> n = cursor.right;
            if (n != null)
                stack.Push(new linkedNode<BSTNode<int>>(n));
            n = cursor.left;
            if(n!=null)
                stack.Push(new linkedNode<BSTNode<int>>(n));


        }

        stack.Traverse();
    }
}

