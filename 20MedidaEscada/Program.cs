using System;

namespace _20MedidaEscada
{
    class Program
    {
        static void Main(string[] args)
        {
           MedidaEscada  medida = new MedidaEscada();


            Console.WriteLine("Digite a distância que a escada está da parede em metros");
            medida.caAdj = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do ângulo");
            medida.angulo = Convert.ToDouble(Console.ReadLine());

            


            medida.message();
            medida.calculoCosseno();
            medida.calculoHipotenusa();
        }
    }
}    