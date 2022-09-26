using System;

class   Trapezoid
{
    static void Main()
    {
        float a, b, p;
        float S;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        p = float.Parse(Console.ReadLine());
        S = ((a + b ) / 2)*p;
        Console.WriteLine(S);
    }
}
