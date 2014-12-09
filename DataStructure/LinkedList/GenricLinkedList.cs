using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class GenericLinkedList<T>
    {
        //Hold a pointe to the root of the listed
        public GenericNode<T> head;



        public GenericLinkedList()
        {
            this.head = null;
        }

        public void AddItem(int position, T item) 
        {
            
        }


        public void AddIteamStart(T item) 
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.dataitem = item;
            newNode.next = this.head;
            this.head = newNode;         

        }




        public void AddItemEnd(T item) 
        {
            GenericNode<T> newNode = new GenericNode<T>();
            newNode.dataitem = item;
            if (this.head ==  null)
            {
                this.head = newNode;
                               
            }
            else
            {
                var temp = this.head;
                while (true)
                {
                    
                }
            }

        }


        public void ReverseList() 
        {
        }

        public void PrintAllItems() 
        {
            GenericNode<T> tempNode = this.head;
            Console.WriteLine("Writing the output");
            if (tempNode == null)
            {
                Console.WriteLine("No item in the list");
            }
            else
            {
                while (tempNode !=  null)
                {

                    Console.WriteLine(tempNode.dataitem);
                    tempNode = tempNode.next;
                }
            }

        }




        public void DeleteAllMatch(T item) 
        {
        }




        public void DeleteFirstMatch(T item) 
        {

        }

        public void DeleteLastMatch(T item) 
        {
        }




    }
}
