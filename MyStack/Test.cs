using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace myStacknamespace
{
    internal class Test
    {
        public static void Main()
        {
            MyStack<String> names = new MyStack<String>();
            names.Push("Leena");
            names.Push("foothill");
            names.Print();
            Console.WriteLine($"top value is: {names.Pop()}");
            names.Print();
            Console.WriteLine($"top value is: {names.Peak()}");
            names.Print();
            names.Clear();
            names.Push("hello");

            MyStack<double> values = new MyStack<double>(5);
            //Notice that I set maxSize = 5
            values.Pop(); // underflow
            values.Push(1.5);
            values.Push(2);
            values.Push(3.3);
            values.Push(4.7);
            values.Push(5);
            values.Print();
            values.Push(6); //overflow because maxSize=5
            values.Print();
            values.Pop();
            values.Print();
            values.Clear();

            values.Push(1111);
            values.Print();

        }


    }
}
