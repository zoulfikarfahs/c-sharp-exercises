/*Calculate and print all the prime numbers between 1 and 100*/


using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;  
        int i, j;  
        //Calculate and display the Prime number  
        Console.WriteLine("Prime Numbers are : ");  
        for (i = 2; i <= 100; i++) {  
            for (j = 2; j <= 100; j++) {  
                if (i != j && i % j == 0) {  
                    isPrime = false;  
                    break;  
                }  
            }  
            if (isPrime) {  
                Console.Write("\t" + i);  
            }  
            isPrime = true;  
        }  
        Console.ReadKey();
        }
    }
}
