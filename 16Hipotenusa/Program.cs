using System;

namespace _16Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            Hipotenusa hip = new Hipotenusa();

            Console.WriteLine("Digite a medida do cateto adjacente em centímetros");
            hip.catetoAdj = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a medida do cateto oposto em centímetros");
            hip.catetoOp = Convert.ToDouble(Console.ReadLine());

            hip.calculoHipotenusa();
            hip.message();

        }
    }
}