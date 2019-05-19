using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(200);
            myList.insertFirst(300);
            myList.insertFirst(400);
            myList.displayLIst();
            myList.insertLast(900);
            myList.displayLIst();

            Console.ReadLine();
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        internal void displayLIst()
        {
            Console.WriteLine("List (First - Last)");
            Node current = first;

            while (current != null)
            {
                current.displayNode();
                current = current.next;

            }
            Console.WriteLine();
        }

        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
            
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }

}
