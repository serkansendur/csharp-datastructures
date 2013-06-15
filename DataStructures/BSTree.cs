using System;
public class BSTNode<T> where T : IComparable<T>
{
    public T Data;
    public BSTNode<T> left;
    public BSTNode<T> right;

    public BSTNode(T Data)
    {
        this.Data = Data;
    }
}

public class BSTree<T> where T : IComparable<T>
{
    public BSTNode<T> root;
    public BSTNode<T> FindNodeByValue(T Data)
    {
        BSTNode<T> cursor = root;

        while (cursor != null)
        {
            int result = cursor.Data.CompareTo(Data);
            if (result == 0)
                break;
            if (result < 0)
                cursor = cursor.right;
            else
                cursor = cursor.left;

        }

        return cursor;
    }

    public void Insert(BSTNode<T> node)
    {
        if (root == null)
        {
            root = node;
        }
        else
        {
            BSTNode<T> cursor = root;

            while (cursor != null)
            {

                int result = cursor.Data.CompareTo(node.Data);
                if (result == 0)
                    break;
                if (result < 0)
                {
                    if (cursor.right != null)
                        cursor = cursor.right;
                    else
                    {
                        cursor.right = node;
                        break;
                    }
                }
                else
                {
                    if (cursor.left != null)
                        cursor = cursor.left;
                    else
                    {
                        cursor.left = node;
                        break;
                    }
                }
            }

        }
    }

    public void PreOrderTraverse(BSTNode<T> node)
    {
        if (node != null)
        {
            Console.WriteLine(node.Data);
            PreOrderTraverse(node.left);
            PreOrderTraverse(node.right);
        }
    }

    public void PostOrderTraverse(BSTNode<T> node)
    {
        if (node != null)
        {
            PreOrderTraverse(node.left);
            PreOrderTraverse(node.right);
            Console.WriteLine(node.Data);
        }
    }

    public void InOrderTraverse(BSTNode<T> node)
    {
        if (node != null)
        {
            PreOrderTraverse(node.left);
            Console.WriteLine(node.Data);
            PreOrderTraverse(node.right);
        }
    }
}