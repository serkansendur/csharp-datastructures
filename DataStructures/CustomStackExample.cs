using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class CustomStackExample
   {
       public static void Execute()
       {
           CustomStack<string> stack = new CustomStack<string>();
           stack.Push(new linkedNode<string>("first"));
           stack.Push(new linkedNode<string>("second"));
           stack.Push(new linkedNode<string>("third"));
           stack.Traverse();
           Console.WriteLine("now try to peek");
           Console.WriteLine(stack.Peek().Data);
           Console.WriteLine("traverse again");
           stack.Traverse();
           Console.WriteLine("now try to pop");
           Console.WriteLine(stack.Pop().Data);
           Console.WriteLine("traverse again");
           stack.Traverse();
           Console.WriteLine("pop two more and traverse again");
           stack.Pop(); stack.Pop(); stack.Traverse();
           Console.WriteLine("push the items back and traverse again");
           stack.Push(new linkedNode<string>("first"));
           stack.Push(new linkedNode<string>("second"));
           stack.Push(new linkedNode<string>("third"));
           stack.Traverse();
       }
   }

