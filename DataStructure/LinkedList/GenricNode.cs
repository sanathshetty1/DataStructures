using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// Represnts a Node in the linkedlist
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenricNode<T>
    {
        public T dataitem;
        public GenricNode<T> next;

    }
}
