using System;

namespace task
{
    class Program
    {
        static void Main()
        {
            int n;
            string result;
             n = int.Parse(Console.ReadLine());

             if (n > 20 && n % 2 == 1)
            {
                 result = "true";
                 Console.WriteLine(result);

            }
            else
             {
                result = "false";
                Console.WriteLine(result);
            }
        }


    }
 }
  
