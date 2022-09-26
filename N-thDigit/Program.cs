using System;


     class N_thDigit
    {
    static void Main()
    {
        int number, n, ndigit;
        number = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        ndigit = (number / (int)Math.Pow(10, n - 1)) % (10);
        if (ndigit == 0)
        {
            Console.WriteLine("---");
        }
        else
        {
            Console.WriteLine(ndigit);
        }
        
    }
}