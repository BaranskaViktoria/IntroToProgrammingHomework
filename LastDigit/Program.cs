using System;
 class LastDigit
    {
        static void Main()
        {
        int n, lastDigit;
        n = int.Parse(Console.ReadLine());
        lastDigit=n % 10;

        Console.WriteLine(lastDigit);
        }
    }