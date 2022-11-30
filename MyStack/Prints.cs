namespace myStacknamespace
{
    internal class Prints<T>
    {
        public static void Print(T[] stack, int count)
        {
            Console.Write("Stack contains:  ");
            if(count ==0)
                Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    Console.Write(stack[i]);
                    Console.WriteLine();

                }
                else
                    Console.Write(stack[i] + ", ");

            }
        }
    }
}
