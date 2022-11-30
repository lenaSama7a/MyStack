using System;
using System.Drawing;
using System.Xml.Linq;

namespace myStacknamespace
{

    class MyStack<T>
    {
        private T[]? stack;
        private int count = 0;
        private readonly int _size = 20;

        public MyStack()
        {
            stack = new T[_size];
        }

        public void Push(T value)
        {
            if (count == _size)
            {
                EnsureCapacity();
            }
            else
            {
                stack[count++] = value;
            }
        }

        private void EnsureCapacity()
        {
            int newSize = _size * 2;
            T[] newStack = new T[newSize];
            for (int i = 0; i < _size; i++)
            {
                newStack[i] = stack[i];
            }
            stack = newStack;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("under flow stack, please push to it first");
            }
            else
            {
                return stack[--count];
            }

        }

        public T Peak()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("under flow stack, please push to it first");
            }
            else
            {
                return stack[count - 1];
            }

        }

        public void Print()
        {
            Prints<T>.Print(stack, count);
            
        }

        public void Clear()
        {
            for (int i = 0; i < stack.Length; i++)
            {
                stack[i] = default(T);
                count = 0;

            }
        }
    }
}