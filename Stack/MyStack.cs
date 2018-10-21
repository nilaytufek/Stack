using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Node<V>
    {
        public V value;

        public Node(V v)
        {
            value = v;
        }
    }

    class MyStack<V>
    {
        Node<V>[] stack = new Node<V>[0];
        int count = 0;
        int size = 0;
        public MyStack(int _size)
        {
            size = _size;
            Array.Resize(ref stack, size);
        }

        public void Push(Node<V> node)
        {
            if (IsFull() == false)
            {
                stack[count] = node;
                count++;
            }
        }
        public V[] GetStack()
        {
            V[] arr = new V[count];

            for (int i = count; i > 0; i--)
            {
                arr[count-i] = stack[i-1].value;
            }            
            return arr;
        }
        public V Pop()
        {
            if (IsEmpty() == false)
            {
                count--;
                return stack[count].value;
            }
            return default(V);
        }

        public bool Search(V val)
        {
            for (int i = 0; i < count; i++)
            {
                if (0 == Comparer<V>.Default.Compare(stack[i].value, val))
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsFull()
        {
            if (count == size - 1)
            {
                return true;
            }
            return false;
        }
        private bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }

    }
}
