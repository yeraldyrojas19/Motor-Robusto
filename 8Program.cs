using System;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Escriba un bucle do-while que le pida al usuario que ingrese dos números.
            Se deben agregar los números y mostrar la suma.
            El bucle debe preguntarle al usuario si desea volver a realizar la operación. Si es así.
            el ciclo debería repetirse; de lo contrario debería terminar.*/
            
            int Suma1, Suma2, resultado, par1 , par2;


            par1 = 0;
            par2 = 0;

            Suma1 = 0; Suma2 = 0;
            Console.WriteLine("Cuantas veces decea realizar esta accion.");
            par2 = Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Primer numero");
                Suma1 = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Segundo numero ");
                Suma2 = Int32.Parse(Console.ReadLine());

                resultado = Suma1 + Suma2;

                Console.WriteLine(" Resultado de la operacion {0} ",resultado);
                 par1++;

            } while (par1 <= par2);
            Console.ReadKey();
        }
             
    }
}
