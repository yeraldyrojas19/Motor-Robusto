using System;

namespace diamante
{
    class Program
    {
        static int Main(string[] args)
        {
			Console.WriteLine("Diamante");
			int a, n, n1;
			int contador = 1;
			
			for (a = 5; a >= 1; a--)
			{
				for (n = 0; n <= a; n++)
				{
				       Console.Write(" ");
				}
				for (n1 = 1; n1 <= contador; n1++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
				contador += 2;
			}
			for (a = 4; a >= 1; a--)
			{
				for (n = 6; n >= a; n--)
				{
					Console.Write(" ");
				}
				for (n1 = 2; n1 <= contador - 3; n1++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
				contador -= 2;


			}
			return 0;

		
		}   
		         
		private static void printf(string v)
		{
			throw new NotImplementedException();
		}
	}
}
