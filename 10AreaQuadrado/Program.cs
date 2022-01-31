using System;

namespace _10AreaQuadrado
{
    class Program
    {
        public static void Main(string [] args)
        {
            AreaQuadrado area = new AreaQuadrado();

            Console.WriteLine("Digite a medida em centímeros do lado do quadrado a ser calculado");
            area.lado = Convert.ToDouble(Console.ReadLine());

            area.calculoAreaQuadrado();
            area.messageCalculoAreaQuadrado();
        
        }
    }   

}