using System;

class Average
    {
        static void Main()
        {
            int  a, b, c;
            float d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = Convert.ToSingle(a + b + c) /3;
            Console.WriteLine(d);
        }
    }
