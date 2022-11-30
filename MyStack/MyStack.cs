using System;

namespace myStacknamespace
{

    class MyStack<T>
    {
        protected readonly T[]? stack;
        public int count = 0;
        protected readonly int _maxSize;
        public MyStack(int maxSize = 20)
        {
            this._maxSize = maxSize;
            stack = new T[maxSize];
        }


        public bool Push(T value)
        { 
            if(count >= _maxSize) 
            {
                throw new IndexOutOfRangeException("over flow stack, It can't add anything");
                return false;
            }
            else
            {
                stack[count++] = value;
                return true;
            }
        }
        
        public T Pop()
        {
            //out T? value

            //value = default;
            //if (count == 0)
            //{
            //    return false;
            //    throw new InvalidOperationException("under flow stack, please push to it first");
            //}
            //else
            //    value = stack[--count];
            //return true;

            if (count == 0)
            {
                throw new InvalidOperationException("under flow stack, please push to it first");
            }
            else
            return stack[--count];
        }

        public T Peak()
        {
            //if (Pop(out var value))
            //{
            //    v = value;
            //    return true;
            //}
            //else
            //    return false;

            return Pop();

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