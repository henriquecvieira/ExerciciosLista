using System;

namespace _22PoligonoConvexo
{
    class Program
    {
        public static void Main(string[] args)
        {
           PoligonoConvexo ND = new PoligonoConvexo();

            Console.WriteLine("Digite a quantidade de lados do polígono");
            ND.n = Convert.ToInt32(Console.ReadLine());

            ND.calculoNumeroDiagonais();
            ND.messageNumeroDiagonais();
        }    
    }      
}      