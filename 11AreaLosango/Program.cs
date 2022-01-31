using System;

namespace _11AreaLosango
{
    class Program
    {
        public static void Main(string [] args)
        {
            AreaLosango losango = new AreaLosango();

            Console.WriteLine("Digite a medida em centímetros do lado maior do losango");
            losango.ladoMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a medida em centímetros do lado menor do losango");
            losango.ladoMenor = Convert.ToDouble(Console.ReadLine());

            losango.calculoAreaLosango();
            losango.messageCalculoAreaLosango();
        }      
        
    }

}