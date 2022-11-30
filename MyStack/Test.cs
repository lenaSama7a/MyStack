using System;

namespace myStacknamespace
{
    internal class Test
    {
        public static void Main()
        {

            MyStack<String> names = new();
            MyStack<double> values = new();

                names.Push("Leena");
                names.Push("AbuSamaha");
                names.Print();

                Console.WriteLine($"top value is: {names.Pop()}");
                names.Print();

                Console.WriteLine($"top value is: {names.Peak()}");
                names.Print();

                names.Clear();
                names.Print();

                names.Push("hello");
                names.Print();

                try
                {
                    values.Pop(); // underflow
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                values.Push(1.5);
                values.Push(2);
                values.Push(3.3);
                values.Push(4.7);
                values.Push(5);
                values.Print();

                values.Pop();
                values.Print();

                values.Clear();
                values.Print();

                values.Push(1111);
                values.Print();


        }


    }
}
