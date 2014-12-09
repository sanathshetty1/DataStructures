using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MainProgram
    {


      static  GenericLinkedList<int> myLinkedList = new GenericLinkedList<int>();
        static void Main(string[] args)
        {
            myLinkedList.AddIteamStart(10);
            //myLinkedList.AddIteamStart(11);
            //myLinkedList.AddIteamStart(12);
            //myLinkedList.AddIteamStart(13);
            //myLinkedList.AddIteamStart(14);

            myLinkedList.PrintAllItems();
            Console.ReadKey();
        }
    }
}
