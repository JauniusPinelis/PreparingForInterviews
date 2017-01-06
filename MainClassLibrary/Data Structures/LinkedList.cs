using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClassLibrary.Data_Structures
{
    public class LinkedList
    {
        //Empty for now   


        public class Node
        {
            public Node Next { get; set; }
            int Data { get; }

            public Node(int d)
            {
                Data = d;
                Next = null;
            }

            public void Append(int d)
            {
                Node end = new Node(d);
                Node n = this;
                while (n.Next != null)
                    n = n.Next;
                n.Next = end;
            }

            public Node DeleteNode(Node head, int d)
            {
                Node n = head;
                if (n.Data == d)
                {
                    return head.Next;
                }
                while (n.Next != null)
                {
                    if (n.Next.Data == d)
                    {
                        n.Next = n.Next.Next;
                        return head;
                    }
                    n = n.Next;
                }
                return n; // d was not found - no changes
            }

            public Node DeleteDublicates(Node head)
            {
                var tempBuffer = new List<int>();
                Node n = head;

                while (n.Next != null)
                {
                    if (tempBuffer.Contains(n.Next.Data))
                    {
                        n.Next = n.Next.Next;
                    }
                    else
                    {
                        tempBuffer.Add(n.Next.Data);
                    }

                    n = n.Next;
                }
                return n;
            }
        }
    }
}
