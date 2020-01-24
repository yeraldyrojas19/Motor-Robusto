using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            Console.WriteLine("Digite el el numero a multiplicar!");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++) 
            {

                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            } 
            Console.ReadKey();

        }
    }
}
