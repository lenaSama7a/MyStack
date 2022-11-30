using System;

namespace myStacknamespace
{
    internal class Test
    {
        public static void Main()
        {

            MyStack<String> names = new();
            MyStack<double> values = new(5);
            //Notice that I set maxSize = 5
            try
            {
                names.Push("Leena");
                names.Push("foothill");
                names.Print();
                
                Console.WriteLine($"top value is: {names.Pop()}");
                names.Print();
                Console.WriteLine($"top value is: {names.Peak()}");
                names.Clear();
                names.Print();
                names.Push("hello");
                names.Print();

                //values.Pop(); // underflow
                values.Push(1.5);
                values.Push(2);
                values.Push(3.3);
                values.Push(4.7);
                values.Push(5);
                values.Print();
                //values.Push(6); //overflow because maxSize=5
                values.Print();
                values.Pop();
                values.Print();
                values.Clear();
                values.Push(1111);
                values.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
