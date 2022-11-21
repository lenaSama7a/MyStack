using System;
namespace myStacknamespace
{
    class MyStack<T>
    {
        private T[]? stack;
        private int count = -1;
        private readonly int maxSize;
        public MyStack(int maxSize = 20) //default is 20, if user doesn't enter it
        {
            this.maxSize = maxSize;
            //Console.WriteLine(maxSize);
            stack = new T[maxSize];
        }

        public void Push(T value)
        { 
            if(count+1 >= maxSize)
            {
                Console.WriteLine("over flow stack, It can't add anything ");

            }
            else
            {
                stack[++count] = value;
            }
        }

        public T Pop()
        {
            if (count == -1)
            {
                Console.WriteLine("under flow stack, please push to it first");
                // throw new InvalidOperationException();
                return default(T);
            }
            else
                return stack[count--];
        }

        public T Peak()
        {
            if (count == -1)
            {
                Console.WriteLine("under flow stack, please push to it first");
                return default(T);
                //throw new InvalidOperationException();
            }
            else
                return stack[count];
        }

        public void Print()
        {
            Console.Write("Stack contains:  ");
            for (int i = 0; i <= count; i++)
            {
                if (i == count )
                {
                    Console.Write(stack[i]);
                    Console.WriteLine();

                }
                else
                    Console.Write(stack[i] + ", ");

            }
        }

        public void Clear()
        {
            Console.WriteLine("Stack after clear:");

            for (int i = 0; i < stack.Length; i++)
            {
                stack[i] = default(T);
                count = -1;
                if(i == (stack.Length-1))
                    Console.WriteLine();
                else
                    Console.Write(stack[i]);

            }
        }
    }
}