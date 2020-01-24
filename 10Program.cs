﻿using System;
using System.Collections.Generic;
using System.Text;

namespace palindrome
{
    class Program
    {
        const int palindrome = 1;
        const int nopalindrome = 0;

        static void Main(string[] args)
        {

            char[] carateres;

            
            Console.WriteLine("Ingrese una palabra: ");
           
            string s = Console.ReadLine();
          
            carateres = new char[s.Length];
           
            carateres = s.ToCharArray(0, s.Length);
            
            if (verificar(0, carateres, s.Length) == palindrome)
                Console.WriteLine("la palabra es palindrome...");
            else
                Console.WriteLine("La palabra no es palindrome...");

        }

        //aquí es donde comparamos las letras de inicio a fin
        static int verificar(int pos, char[] palabra, int largo)
        {
           
            if (palabra[pos] == palabra[largo - pos - 1])
            {
               
                if (pos < largo - pos)
                    return (verificar(++pos, palabra, largo));
                else
                    return (palindrome);
            }
           
            return (nopalindrome);
        }
    }
}