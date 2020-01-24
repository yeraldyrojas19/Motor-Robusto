using System;

namespace Numeros_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int par1, par2, par3;

            int num1;
            par1 = 0;
            par2 = 1;
            par3 = 1;
            Console.Write("Introdusca los numeros de Fibonacci : ");

            num1 = Int32.Parse(Console.ReadLine());
            while ( par3 <= num1)
            {

                par1 = par1 + par2; 
                par2 = par1 - par2;

              par3++;

                Console.WriteLine(par1);
            }
            Console.ReadKey();

             


        }
    }
}
