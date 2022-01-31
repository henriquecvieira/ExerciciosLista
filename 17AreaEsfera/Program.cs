using System;

namespace _17AreaEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaEsfera ae = new AreaEsfera();

            Console.WriteLine("Digite a medida do raio da esfera em centímetros");
            ae.raio = Convert.ToDouble(Console.ReadLine());

            ae.message();
            ae.calculoCircunferencia();
            ae.calculoAreaEsfera();
            ae.calculoVolumeEsfera();



        }
    }
}    