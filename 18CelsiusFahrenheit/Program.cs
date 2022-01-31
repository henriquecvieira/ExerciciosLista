using System;

namespace _18CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
           CelsiusFahrenheit  cF = new CelsiusFahrenheit();

            Console.WriteLine("Digite a temperatura em Celsius");
            cF.Celsius = Convert.ToDouble(Console.ReadLine());

            cF.message();
            cF.calculoCelsiusParaFahrenheit();
        }
    }
}    