using System;

namespace _13Tabuada
{
    public class Tabuada
    {
        public static void Calcular(int numero)
        {              
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                
            }
           

        }
    }
}