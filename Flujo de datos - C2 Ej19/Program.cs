using System;

namespace Flujo_de_datos___C2_Ej19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2 == 0) & (i % 3 == 0))
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}
