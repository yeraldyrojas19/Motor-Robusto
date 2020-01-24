using System;

namespace Conteo_atras
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1, variable2, variable3;

            variable2 = 0; variable3 = 0;

            Console.WriteLine("introdusca un numero");

            variable1 = Int32.Parse(Console.ReadLine());

            variable3 = variable1;

            while (variable2 <= variable1)
            {
                Console.Write("{0},",variable3);
                variable2++; variable3--;
            }

            Console.ReadKey();
        }
    }
}
