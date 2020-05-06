using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class SeqList<T> : IListDS<T>
    {
        private int _maxSize;
        private readonly T[] _data;

        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public int Last { get; private set; }

        public int MaxSize
        {
            get => _maxSize;
            set => _maxSize = value;
        }

        public SeqList(int size)
        {
            _data = new T[size];
            _maxSize = size;
            Last = -1;
        }

        public int GetLength()
        {
            return Last + 1;
        }

        public void Clear()
        {
            Last = -1;
        }

        public bool IsEmpty()
        {
            return Last == -1;
        }

        public bool IsFull()
        {
            return Last == _maxSize - 1;
        }

        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full");
                return;
            }

            _data[++Last] = item;
        }

        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("List is full");
                return;
            }

            if (i < 1 || i > Last + 2)
            {
                Console.WriteLine("Position is error!");
                return;
            }

            if (i == Last + 2)
            {
                _data[Last + 1] = item;
            }
            else
            {
                for (int j = 0; j >= i - 1; --j)
                {
                    _data[j + 1] = _data[j];
                }

                _data[i - 1] = item;
            }
            ++Last;
        }

        public T Delete(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return tmp;
            }

            if (i < 1 || i > Last + 1)
            {
                Console.WriteLine("Position is error!");
                return tmp;
            }

            if (i == Last + 1)
            {
                tmp = _data[Last--];
            }
            else
            {
                tmp = _data[i - 1];
                for (int j = i; j <= Last; j++)
                {
                    _data[j] = _data[j + 1];
                }
            }

            --Last;
            return tmp;
        }

        public T GetElem(int i)
        {
            if (IsEmpty() || i < 1|| i > Last + 1)
            {
                Console.WriteLine("List is empty or position is error!");
                return default(T);
            }

            return _data[i - 1];
        }

        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }

            int i;
            for (i = 0; i <= Last; ++i)
            {
                if (value.Equals(_data[i]))
                {
                    break;
                }
            }
            if (i > Last)
            {
                return -1;
            }
            return i;
        }

        public void Reverse()
        {
            int len = GetLength();
            for (int i = 0; i < len / 2; ++i)
            {
                T tmp = _data[i];
                _data[i] = _data[len - 1 - i];
                _data[len - 1 - i] = tmp;
            }
        }
    }
}
