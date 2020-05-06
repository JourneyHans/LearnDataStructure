using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public T Data
        {
            get => _data;
            set => _data = value;
        }

        public Node<T> Next
        {
            get => _next;
            set => _next = value;
        }

        public Node(T data, Node<T> node)
        {
            _data = data;
            _next = node;
        }

        public Node(Node<T> node)
        {
            _next = node;
        }

        public Node(T data)
        {
            _data = data;
            _next = null;
        }

        public Node()
        {
            _data = default(T);
            _next = null;
        }
    }
}
