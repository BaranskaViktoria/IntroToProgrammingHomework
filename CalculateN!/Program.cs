using System;


    internal class CalculateN_
    {
        static void Main()
        {
            int n, factorial=1;
            n =int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }           
        Console.WriteLine(factorial);
        }
    }

