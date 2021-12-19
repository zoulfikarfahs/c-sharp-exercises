
/*Print all the numbers divisible by 5 or 7, from 1 to 100.*/
using System;

namespace dividedBy5or7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("i numeri divisibili con 5 & 7: ");
            for (int i=1;i<=100;i++)
            {
                if(i%5==0 && i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
