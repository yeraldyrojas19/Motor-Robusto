using System;

namespace suma_de_los_pares_e_impares_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, var3;

            int par, par2;

            par = 1;

            var1 = 0; var2 = 0; var3 = 0;

            Console.Write("introducir cuantos numeros quieres: ");
            par2 = Convert.ToInt32(Console.ReadLine());
            
            while (par <= par2)
            {
                bool pri = true;
                for (int cont = par - 1; cont > 1; cont--)
                {

                    if (par % cont == 0)
                    {
                        pri = false;
                    }

                }
               
                
                if (pri)
                {
                    var3 = var3 + par;
             
                }
                if (par % 2 == 0)
                {
                    
                    var2 = var2 + par;
                }

                else
                {
                    var1 = var1 + par;

                }
                par++;


            }
            
            Console.WriteLine("Suma imparares, "+var1);
            Console.WriteLine("Suma pares, "+var2);
            Console.WriteLine("Suma primo, "+var3);
            Console.WriteLine("Fin de la operacion");
            Console.ReadKey();
        }
    }
}
