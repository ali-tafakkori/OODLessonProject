using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODLessonProject.P11
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void AddToFirst(T data)
        {
            Node<T> newNode = new Node<T> { Data = data };
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        public void AddToLast(T data)
        {
            Node<T> newNode = new Node<T> { Data = data };
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public void AddAfter(Node<T> existingNode, T data)
        {
            if (existingNode != null)
            {
                Node<T> newNode = new Node<T> { Data = data, Next = existingNode.Next };
                existingNode.Next = newNode;
                if (existingNode == tail)
                {
                    tail = newNode;
                }
            }
        }
        public void RemoveFromFirst()
        {
            if (head != null)
            {
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
            }
        }
        public void RemoveFromLast()
        {
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
            }
        }
        public void RemoveAfter(Node<T> existingNode)
        {
            if (existingNode != null && existingNode.Next != null)
            {
                if (existingNode.Next == tail)
                {
                    tail = existingNode;
                }
                existingNode.Next = existingNode.Next.Next;
            }
        }
        public Node<T> Search(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void Reverse()
        {
            Node<T> previous = null;
            Node<T> current = head;
            Node<T> next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }
        public string Print()
        {
            string s = "";
            Node<T> current = head;
            while (current != null)
            {
                s += current.Data + " ";
                current = current.Next;
            }
            return s;
        }
    }
}
