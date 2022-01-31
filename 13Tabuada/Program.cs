using System;

namespace _13Tabuada
{
    class Program
    {
        public static void Main(string [] args)
        {
            //Tabuada tabuada = new Tabuada();

            Console.WriteLine("Digite o número que deseja na tabuada");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ↓↓↓↓↓↓↓↓");

            Tabuada.Calcular(numero);


        }
    }
}