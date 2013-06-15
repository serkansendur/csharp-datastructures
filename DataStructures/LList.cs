using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        public class LList<T>
        {
            public linkedNode<T> Head
            {
                get
                {
                    return head;
                }
            }
            private linkedNode<T> head;
            private linkedNode<T> tail;
            public void AddFirst(linkedNode<T> node)
            {
                if (head == null)
                {
                    head = tail = node;
                    head.next = tail;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
            }

            public void AddLast(linkedNode<T> node)
            {
                if (tail == null)
                {
                    tail = head = node;
                    head.next = tail;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
            }

            // inserting after a node is much easier than before a node in a singly linked list because there is no 
            // pointer to the node pointing at the current, unlike a doubly linked list.
            public void insertAfter(linkedNode<T> nodeBefore, linkedNode<T> node)
            {
                linkedNode<T> nodeAfter = nodeBefore.next;
                nodeBefore.next = node;
                node.next = nodeAfter;

            }

            public void removeLink(linkedNode<T> node)
            {
                linkedNode<T> nodeBefore = FindNodeBefore(node);
                // if node not found, just return
                if (nodeBefore == null)
                    return;
                if (object.ReferenceEquals(head, node))
                {
                    head = node;
                }
                if (object.ReferenceEquals(tail, node))
                {
                    tail = nodeBefore;
                }

                nodeBefore.next = node.next;
            }

            // finding the node before the current requires traversal of a singly linked list.
            public linkedNode<T> FindNodeBefore(linkedNode<T> node)
            {
                // there is no node before the head, so return null
                if (object.ReferenceEquals(node, head))
                    return null;
                linkedNode<T> nodeBefore = head;
                linkedNode<T> cursor = head;
                while (cursor != null)
                {

                    if (object.ReferenceEquals(node, cursor))
                        return nodeBefore;

                    nodeBefore = cursor;

                    cursor = cursor.next;
                }
                //if nothing found, return null
                return null;
            }

            public void Traverse()
            {
                linkedNode<T> cursor = this.Head;
                while (cursor != null)
                {
                    Console.WriteLine(cursor.Data);
                    cursor = cursor.next;
                }
            }
        }
       

       
    

