using System;

namespace _19LightPerMeter
{
    class Program
    {
        static void Main(string[] args)
        {
           LightPerMeter  lp = new LightPerMeter();


            Console.WriteLine("Digite a largura em metros");
            lp.largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento em metros");
            lp.comprimento = Convert.ToDouble(Console.ReadLine());

            

            lp.message();
            lp.calculoAreaQauarto();
            lp.calculoPotencia();
        }
    }
}    