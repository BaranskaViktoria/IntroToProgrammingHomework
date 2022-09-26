using System;


    internal class PrograBiggestOfThreem
    {
        static void Main()
        {
        int a, b, c;
        Console.WriteLine("Введить 3 числа через пробил");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if (a > b & a > c) 
            Console.WriteLine(a);
        else if (b > c & b>a)
            Console.WriteLine(b);
        else
            Console.WriteLine(c);
    }
    }
