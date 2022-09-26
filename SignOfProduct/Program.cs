using System;
 class SignOfProduct
    {
        static void Main()
        {
        float a, b, c;
         string  product;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());
        if (a<0 && b<0 && c<0 || a<0 && b>0 && c>0|| a>0 && c>0 &&b<0 ||a>0 && c<0 && b>0)
        {
            product = "negative";
            Console.WriteLine(product);
        }
        else
        {
            product = "positive";
            Console.WriteLine(product);
        }
        }
    }

