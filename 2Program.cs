using System;

namespace num_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int var, var2; var = 1;
            Console.WriteLine("introducir los numeros imprares");
            var2 = Convert.ToInt32(Console.ReadLine());
            while (var <= var2)
            {
                if ( var % 2 == 0)
                {

                }
                else
                {
                    Console.WriteLine(var + ",");
                
                }
                var++;
            }

            Console.ReadKey();
        }       
    }
}
