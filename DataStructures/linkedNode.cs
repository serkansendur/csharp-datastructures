using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class linkedNode<T>
{
    public linkedNode<T> next;
    public T Data;
    public linkedNode(T Data)
    {
        this.Data = Data;
    }
}

