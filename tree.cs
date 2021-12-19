using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
           int spaces = 10;
        int asterix = 1;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");   
            }
            for (int j = 0; j < asterix; j++)
            {
                Console.Write("* ");//per avere numeri al posto dell'asterisco basta sostiruire * con j
            }
            Console.WriteLine();
            asterix++;
            spaces--;
        }
        }
    }
}
