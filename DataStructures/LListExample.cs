using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class LListExample
   {
       public static void Execute()
       {
           LList<string> list = new LList<string>();
           list.AddFirst(new linkedNode<string>("first to left"));
           list.AddFirst(new linkedNode<string>("second to left"));
           list.AddLast(new linkedNode<string>("first to right"));
           list.AddLast(new linkedNode<string>("second to right"));
           list.AddFirst(new linkedNode<string>("third to left"));
           list.AddLast(new linkedNode<string>("third to right"));
           linkedNode<string> newLastNode = new linkedNode<string>("last node");
           list.AddLast(newLastNode);
           list.insertAfter(newLastNode, new linkedNode<string>("inserted first after the last"));
           list.insertAfter(newLastNode, new linkedNode<string>("inserted second after the last, but will appear right after the last"));

           list.Traverse();

           Console.WriteLine("list2 items are being displayed");
           LList<string> list2 = new LList<string>();

           list2.AddLast(new linkedNode<string>("first item"));
           list2.AddLast(new linkedNode<string>("second item"));
           linkedNode<string> thirdItem = new linkedNode<string>("third item");
           list2.AddLast(thirdItem);
           list2.AddLast(new linkedNode<string>("fourth item"));
           list2.AddLast(new linkedNode<string>("fifth item"));

           list2.removeLink(thirdItem);

           list2.Traverse();

           Console.ReadLine();
       }
    }

