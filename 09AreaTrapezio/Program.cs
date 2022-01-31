using System;

namespace _09AreaTrapezio
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculoAreaTrapezio area = new CalculoAreaTrapezio();

            Console.WriteLine("infome a medida em centimetros da base maior do trapézio");
            area.baseMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("infome a medida em centimetros da base menor do trapézio");
            area.baseMenor = Convert.ToDouble(Console.ReadLine());

            area.calculoAreaTrapezio();
            area.messageCalculoAreaTrapezio();
        }
    }
        
}