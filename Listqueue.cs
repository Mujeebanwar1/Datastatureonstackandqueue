using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastaructureonstackandqueue
{
    internal class Listqueue
    {

        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;

            }
            Console.WriteLine("{0} inserted into quean ", node.data);
        }
        internal void Dispaly()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            Console.WriteLine("value queue is {0}", head.data);
            head = head.next;
        }
    }
}
