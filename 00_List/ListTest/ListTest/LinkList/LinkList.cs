using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest.LinkList
{
    public class LinkList<T>:IListDS<T>
    {
        private Node<T> _head;

        public Node<T> Head
        {
            get => _head;
            set => _head = value;
        }

        public LinkList()
        {
            _head = null;
        }

        public int GetLength()
        {
            Node<T> iterNode = _head;
            int len = 0;
            while (iterNode != null)
            {
                ++len;
                iterNode = iterNode.Next;
            }
            return len;
        }

        public void Clear()
        {
            _head = null;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (IsEmpty())
            {
                _head = newNode;
                return;
            }

            Node<T> iterNode = _head;
            while (iterNode.Next != null)
            {
                iterNode = iterNode.Next;
            }
            iterNode.Next = newNode;
        }

        public void InsertBefore(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is empty or position is error");
                return;
            }

            if (i == 1)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = _head;
                _head = newNode;
                return;
            }

            Node<T> iterNode = _head;
            Node<T> lastOfIterNode = new Node<T>();
            int index = 1;
            while (iterNode.Next != null && index < i)
            {
                lastOfIterNode = iterNode;
                iterNode = iterNode.Next;
                ++index;
            }

            if (index == i)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = iterNode;
                lastOfIterNode.Next = newNode;
            }
        }

        public void InsertAfter(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is empty or position is error");
                return;
            }

            if (i == 1)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = _head.Next;
                _head.Next = newNode;
                return;
            }

            Node<T> iterNode = _head;
            int index = 1;
            while (iterNode != null && index < i)
            {
                iterNode = iterNode.Next;
                ++index;
            }

            if (index == i)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = iterNode.Next;
                iterNode.Next = newNode;
            }
        }

        public T Delete(int i)
        {
            throw new NotImplementedException();
        }

        public T GetElem(int i)
        {
            throw new NotImplementedException();
        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
