using System;

 internal class NumberAsDayOfWeek
    {
        static void Main()
        {
        int n;
        n= int.Parse(Console.ReadLine());
        if (n<=7 & n >=1) { 
                switch (n)
                 { 
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday ");
                    break;
                }
        }
        else
        {
            Console.WriteLine("not valid");
        }

     
    }
}
